// This is a comment
// uncomment the line below if you want to write a filterscript
//#define FILTERSCRIPT

#if defined _MDPWN_ShotData
	#endinput
#endif
#define _MDPWN_ShotData



forward AddHandler_ShotData();
forward WeaponShotHandler_ShotData(playerid, weaponid, hittype, hitid, Float:fX, Float:fY, Float:fZ);


public AddHandler_ShotData()
{
	AddHandler("ShotData",WeaponShotHandler);  // commanhanler 명령어 
}


public WeaponShotHandler_ShotData(playerid, weaponid, hittype, hitid, Float:fX, Float:fY, Float:fZ)
{ 
    new Float:pX,Float:pY,Float:pZ;
    if(hittype == 1)
    {
        GetPlayerPos(hitid,pX,pY,pZ);  // 차량도?
    }
    if(hittype == 2)
    {        
        GetVehiclePos(hitid,pX,pY,pZ);
    }
    ShotDataSave(playerid, weaponid,hittype, hitid, fX+pX,fY+pY,fZ+pZ);

}


stock ShotDataSave(playerid, weaponid, hittype, hitid, Float:fX, Float:fY, Float:fZ)
{
    new string[512];
    //-----
    format(string,sizeof(string),"INSERT INTO ShotData (attacker,hitid,weaponid,hittype,fx,fy,fz) VALUES");
	format(string,sizeof(string),"%s ('%s'",string,GetPlayerNameEx(playerid));	
	if(hittype == 1)
    format(string,sizeof(string),"%s, '%s'",string,GetPlayerNameEx(hitid) );//hit person
	else
    format(string,sizeof(string),"%s, '%i'",string,hitid);//etc
    format(string,sizeof(string),"%s, %i",string,weaponid);
	format(string,sizeof(string),"%s, %i",string,hittype);    
    //-----
	format(string,sizeof(string),"%s, %.3f",string,fX);//hitid 는 3항연산자
	format(string,sizeof(string),"%s, %.3f",string,fY);
	format(string,sizeof(string),"%s, %.3f)",string,fZ);
	//-----
	mysql_pquery(GetMySQLHandle(),string);
}
