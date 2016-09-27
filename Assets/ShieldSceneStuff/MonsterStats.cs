using UnityEngine;
using System.Collections;

public class MonsterStats : MonoBehaviour {

	private int level;

	private int maxHP;
	private int HP;
	
	private int maxVital;
	private int vital;
	
	private int maxMP;
	private int MP;
	
	private int STR;
	private int CON;
	private int AGI;
	private int DEX;
	private int MGP;




	public MonsterStats ()
	{
		level = 1;
		maxHP = 100;
		HP = maxHP;
		maxVital = 100;
		vital = maxVital;
		STR = 10;
		CON = 10;
		AGI = 10;
		DEX = 10;
		MGP = 10;
	}
	
	public MonsterStats (int lvl,int H,int V,int M,int S,int C,int A,int D,int mag)
	{
		level = lvl;
		maxHP = H;
		HP = maxHP;
		maxVital = V;
		vital = maxVital;
		maxMP = M;
		MP = maxMP;
		STR = S;
		CON = C;
		AGI = A;
		DEX = D;
		MGP = mag;
	}
	

	//////////////////////////////////////////////////////////////////////////////////////////

	// ############### Get level ############### //

	public int GetLevel()
	{
		return level;
	}

	// ############### Get level ############### //


	/////////////////////////////////////////////


	// ############### set level ############### //

	public void SetLevel (int set)
	{
		level = set;
	}

	// ############### set level ############### //


	/////////////////////////////////////////////


	// ############### level up ############### //

	public void LevelUp()
	{
		level++;
	}

	// ############### level up ############### //


	//////////////////////////////////////////////////////////////////////////////////////////


	// ############### Get Max HP ############### //
	
	public int GetMaxHP()
	{
		return maxHP;
	}
	
	// ############### Get Max HP ################ //
	
	
	/////////////////////////////////////////////
	
	
	// ############### Set Max HP ################ //
	
	public void SetMaxHP(int set)
	{
		maxHP = set;
		if (HP > maxHP)
			HP = maxHP;
		
	}
	public void SetMaxHP(float set)
	{
		maxHP = Extras.Round (set);
		if (HP > maxHP)
			HP = maxHP;
	}
	public void SetMaxHP(double set)
	{
		maxHP = Extras.Round (set);
		if (HP > maxHP)
			HP = maxHP;
	}
	public void SetMaxHP(decimal set)
	{
		maxHP = Extras.Round (set);
		if (HP > maxHP)
			HP = maxHP;
	}
	
	// ################ Set Max HP ############# //
	
	
	//////////////////////////////////////////////////////////////////////////////////////////
	
	
	// ############### Get Max Vital ############### //
	
	public int GetMaxVital()
	{
		return maxVital;
	}
	
	// ############### Get Max Vital ################ //
	
	
	/////////////////////////////////////////////
	
	
	// ############### Set Max Vital ################ //
	
	public void SetMaxVital(int set)
	{
		maxVital = set;
		if (vital > maxVital)
			vital = maxVital;
		
	}
	public void SetMaxVital(float set)
	{
		maxVital = Extras.Round (set);
		if (vital > maxVital)
			vital = maxVital;
	}
	public void SetMaxVital(double set)
	{
		maxVital = Extras.Round (set);
		if (vital > maxVital)
			vital = maxVital;
	}
	public void SetMaxVital(decimal set)
	{
		maxVital = Extras.Round (set);
		if (vital > maxVital)
			vital = maxVital;
	}
	
	// ################ Set Max Vital ############# //
	
	
	//////////////////////////////////////////////////////////////////////////////////////////
	
	
	// ############### Get Max MP ############# //
	
	public int GetMaxMP()
	{
		return maxMP;
	}
	
	// ############# Get Max MP ############## //
	
	
	/////////////////////////////////////////////
	
	
	// ############# Set Max MP ############# //
	
	public void SetMaxMP(int set)
	{
		maxMP = set;
		if (MP > maxMP)
			MP = maxMP;
		
	}
	public void SetMaxMP(float set)
	{
		maxMP = Extras.Round (set);
		if (MP > maxMP)
			MP = maxMP;
	}
	public void SetMaxMP(double set)
	{
		maxMP = Extras.Round (set);
		if (MP > maxMP)
			MP = maxMP;
	}
	public void SetMaxMP(decimal set)
	{
		maxMP = Extras.Round (set);
		if (MP > maxMP)
			MP = maxMP;
	}
	
	// ############### Set Max MP ############### //
	
	
	//////////////////////////////////////////////////////////////////////////////////////////
	
	
	// ################## Get HP ################ //
	
	public int GetHP()
	{
		return HP;
	}
	
	// ################# Get HP ################ //
	
	
	/////////////////////////////////////////////
	
	
	// ################# Set HP ############### //
	
	public void SetHP(int set)
	{
		HP = set;
		if (HP > maxHP)
			HP = maxHP;
	}
	public void SetHP(float set)
	{
		HP = Extras.Round (set);
		if (HP > maxHP)
			HP = maxHP;
	}
	public void SetHP(double set)
	{
		HP = Extras.Round (set);
		if (HP > maxHP)
			HP = maxHP;
	}
	public void SetHP(decimal set)
	{
		HP = Extras.Round (set);
		if (HP > maxHP)
			HP = maxHP;
	}
	
	// ################# Set HP ############### //
	
	
	/////////////////////////////////////////////
	
	
	// ################## Damage ################ //
	
	public void Damage(int dam)
	{
		HP -= dam;
	}
	public void Damage(float dam)
	{
		HP -= Extras.Round(dam);
	}
	public void Damage(double dam)
	{
		HP -= Extras.Round(dam);
	}
	public void Damage(decimal dam)
	{
		HP -= Extras.Round(dam);
	}
	
	// ################## Damage #################### //
	
	
	/////////////////////////////////////////////
	
	
	// ################## Healing ################### //
	
	public void Heal(int hl)
	{
		HP += hl;
		if (HP > maxHP)
			HP = maxHP;
	}
	public void Heal(float hl)
	{
		HP += Extras.Round (hl);
		if (HP > maxHP)
			HP = maxHP;
	}
	public void Heal(double hl)
	{
		HP += Extras.Round (hl);
		if (HP > maxHP)
			HP = maxHP;
	}
	public void Heal(decimal hl)
	{
		HP += Extras.Round (hl);
		if (HP > maxHP)
			HP = maxHP;
	}
	
	// #################### Healing ############### //
	
	
	//////////////////////////////////////////////////////////////////////////////////////////
	
	
	// ################## Get vital ################ //
	
	public int GetVital()
	{
		return vital;
	}
	
	// ################# Get vital ################ //
	
	
	/////////////////////////////////////////////
	
	
	// ################# Set vital ############### //
	
	public void SetVital(int set)
	{
		vital = set;
		if (vital > maxVital)
			vital = maxVital;
	}
	public void SetVital(float set)
	{
		vital = Extras.Round (set);
		if (vital > maxVital)
			vital = maxVital;
	}
	public void SetVital(double set)
	{
		vital = Extras.Round (set);
		if (vital > maxVital)
			vital = maxVital;
	}
	public void SetVital(decimal set)
	{
		vital = Extras.Round (set);
		if (vital > maxVital)
			vital = maxVital;
	}
	
	// ################# Set vital ############### //
	
	
	/////////////////////////////////////////////
	
	
	// ################## Damage ################ //
	
	public void DamageVital(int dam)
	{
		vital -= dam;
	}
	public void DamageVital(float dam)
	{
		vital -= Extras.Round(dam);
	}
	public void DamageVital(double dam)
	{
		vital -= Extras.Round(dam);
	}
	public void DamageVital(decimal dam)
	{
		vital -= Extras.Round(dam);
	}
	
	// ################## Damage #################### //
	
	
	/////////////////////////////////////////////
	
	
	// ################## Healing ################### //
	
	public void HealVital(int hl)
	{
		vital += hl;
		if (vital > maxVital)
			vital = maxVital;
	}
	public void HealVital(float hl)
	{
		vital += Extras.Round (hl);
		if (vital > maxVital)
			vital = maxVital;
	}
	public void HealVital(double hl)
	{
		vital += Extras.Round (hl);
		if (vital > maxVital)
			vital = maxVital;
	}
	public void HealVital(decimal hl)
	{
		HP += Extras.Round (hl);
		if (HP > maxVital)
			HP = maxVital;
	}
	
	// #################### Healing ############### //
	
	
	//////////////////////////////////////////////////////////////////////////////////////////
	
	
	// ################## Get MP ################ //
	
	public int GetMP()
	{
		return MP;
	}
	
	// ################# Get MP ################ //
	
	
	/////////////////////////////////////////////
	
	
	// ################# Set MP ############### //
	
	public void SetMP(int set)
	{
		MP = set;
		if (MP > maxMP)
			MP = maxMP;
	}
	public void SetMP(float set)
	{
		MP = Extras.Round(set);
		if (MP > maxMP)
			MP = maxMP;
	}
	public void SetMP(double set)
	{
		MP = Extras.Round(set);
		if (MP > maxMP)
			MP = maxMP;
	}
	public void SetMP(decimal set)
	{
		MP = Extras.Round(set);
		if (MP > maxMP)
			MP = maxMP;
	}
	
	// ################# Set MP ############### //
	
	
	/////////////////////////////////////////////
	
	
	// ################## Draining MP ################ //
	
	public void DrainMP(int dam)
	{
		MP -= dam;
	}
	public void DrainMP(float dam)
	{
		MP -= Extras.Round(dam);
	}
	public void DrainMP(double dam)
	{
		MP -= Extras.Round(dam);
	}
	public void DrainMP(decimal dam)
	{
		MP -= Extras.Round(dam);
	}
	
	// ################## Draining MP #################### //
	
	
	/////////////////////////////////////////////
	
	
	// ################## Restoring MP ################### //
	
	public void RestoreMP(int hl)
	{
		MP += hl;
		if (MP > maxMP)
			MP = maxMP;
	}
	public void RestoreMP(float hl)
	{
		MP += Extras.Round (hl);
		if (MP > maxMP)
			MP = maxMP;
	}
	public void RestoreMP(double hl)
	{
		MP += Extras.Round (hl);
		if (MP > maxMP)
			MP = maxMP;
	}
	public void RestoreMP(decimal hl)
	{
		MP += Extras.Round (hl);
		if (MP > maxMP)
			MP = maxMP;
	}
	
	// #################### Restoring MP ############### //
	
	
	//////////////////////////////////////////////////////////////////////////////////////////
	
	
	// ################### Get STR #################### //
	
	public int GetSTR()
	{
		return STR;
	}
	
	// ################## Get STR #################### //
	
	
	/////////////////////////////////////////////
	
	
	// ################## Set STR ################### //
	
	public void SetSTR(int set)
	{
		STR = set;
	}
	public void SetSTR(float set)
	{
		STR = Extras.Round (set);
	}
	public void SetSTR(double set)
	{
		STR = Extras.Round (set);
	}
	public void SetSTR(decimal set)
	{
		STR = Extras.Round (set);
	}
	
	// ################# Set STR ################### //
	
	
	//////////////////////////////////////////////////////////////////////////////////////////
	
	
	// ################### Get CON #################### //
	
	public int GetCON()
	{
		return CON;
	}
	
	// ################## Get CON #################### //
	
	
	/////////////////////////////////////////////
	
	
	// ################## Set CON ################### //
	
	public void SetCON(int set)
	{
		CON = set;
	}
	public void SetCON(float set)
	{
		CON = Extras.Round (set);
	}
	public void SetCON(double set)
	{
		CON = Extras.Round (set);
	}
	public void SetCON(decimal set)
	{
		CON = Extras.Round (set);
	}
	
	// ################# Set CON ################### //
	
	
	//////////////////////////////////////////////////////////////////////////////////////////
	
	
	// ################### Get AGI #################### //
	
	public int GetAGI()
	{
		return AGI;
	}
	
	// ################## Get AGI #################### //
	
	
	/////////////////////////////////////////////
	
	
	// ################## Set AGI ################### //
	
	public void SetAGI(int set)
	{
		AGI = set;
	}
	public void SetAGI(float set)
	{
		AGI = Extras.Round (set);
	}
	public void SetAGI(double set)
	{
		AGI = Extras.Round (set);
	}
	public void SetAGI(decimal set)
	{
		AGI = Extras.Round (set);
	}
	
	// ################# Set AGI ################### //
	
	
	//////////////////////////////////////////////////////////////////////////////////////////
	
	
	// ################### Get DEX #################### //
	
	public int GetDEX()
	{
		return DEX;
	}
	
	// ################## Get DEX #################### //
	
	
	/////////////////////////////////////////////
	
	
	// ################## Set DEX ################### //
	
	public void SetDEX(int set)
	{
		DEX = set;
	}
	public void SetDEX(float set)
	{
		DEX = Extras.Round (set);
	}
	public void SetDEX(double set)
	{
		DEX = Extras.Round (set);
	}
	public void SetDEX(decimal set)
	{
		DEX = Extras.Round (set);
	}
	
	// ################# Set DEX ################### //
	
	
	//////////////////////////////////////////////////////////////////////////////////////////
	
	
	// ################### Get MGP #################### //
	
	public int GetMGP()
	{
		return MGP;
	}
	
	// ################## Get MGP #################### //
	
	
	/////////////////////////////////////////////
	
	
	// ################## Set MGP ################### //
	
	public void SetMGP(int set)
	{
		MGP = set;
	}
	public void SetMGP(float set)
	{
		MGP = Extras.Round (set);
	}
	public void SetMGP(double set)
	{
		MGP = Extras.Round (set);
	}
	public void SetMGP(decimal set)
	{
		MGP = Extras.Round (set);
	}
	
	// ################# Set MGP ################### //
	
	
	//////////////////////////////////////////////////////////////////////////////////////////

}
