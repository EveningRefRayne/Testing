using UnityEngine;
using System.Collections;

public class BlessedStats {

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
	private int SPI;

	private int HPGrowth;
	private int MPGrowth;
	private int STRGrowth;
	private int CONGrowth;
	private int AGIGrowth;
	private int DEXGrowth;
	private int MGPGrowth;
	private int SPIGrowth;

	private float HPAffinity;
	private float MPAffinity;
	private float STRAffinity;
	private float CONAffinity;
	private float AGIAffinity;
	private float DEXAffinity;
	private float MGPAffinity;
	private float SPIAffinity;

	//////////////////////////////////////////////////////////////////////////////////////////

	// ############### Constructors ############# //

	public BlessedStats ()
	{
		level = 1;
		maxHP = 1000;
		HP = maxHP;
		maxVital = 100;
		vital = maxVital;
		STR = 10;
		CON = 10;
		AGI = 10;
		DEX = 10;
		MGP = 10;
		SPI = 10;
		HPGrowth = 0;
		MPGrowth = 0;
		STRGrowth = 0;
		CONGrowth = 0;
		AGIGrowth = 0;
		DEXGrowth = 0;
		MGPGrowth = 0;
		SPIGrowth = 0;
		HPAffinity = 1;
		MPAffinity = 1;
		STRAffinity = 1;
		CONAffinity = 1;
		AGIAffinity = 1;
		DEXAffinity = 1;
		MGPAffinity = 1;
		SPIAffinity = 1;
	}

	public BlessedStats (int lvl,int H,int V,int M,int S,int C,int A,int D,int mag,int SP,int HG,int MG,int SG,int CG,int AG,int DG,int magG,int SPG,int HA,int MA,int SA,int CA,int AA,int DA,int magA,int SPA)
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
		SPI = SP;
		HPGrowth = HG;
		MPGrowth = MG;
		STRGrowth = SG;
		CONGrowth = CG;
		AGIGrowth = AG;
		DEXGrowth = DG;
		MGPGrowth = magG;
		SPIGrowth = SPG;
		HPAffinity = HA;
		MPAffinity = MA;
		STRAffinity = SA;
		CONAffinity = CA;
		AGIAffinity = AA;
		DEXAffinity = DA;
		MGPAffinity = magA;
		SPIAffinity = SPA;
	}

	//////////////////////////////////////////////////////////////////////////////////////////

	// ############### Get level ############### //
	
	public int GetLevel()
	{
		return level;
	}
	
	// ############### Get level ################ //
	
	
	/////////////////////////////////////////////
	
	
	// ############### Set level ################ //
	
	public void SetLevel(int set)
	{
		level = set;
		
	}
	
	// ################ Set level ############# //


	/////////////////////////////////////////////
	
	
	// ############### level up ################ //
	
	public void LevelUp()
	{
		level++;
		
	}
	
	// ################ level up ############# //
	
	
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
	
	
	// ################### Get SPI #################### //
	
	public int GetSPI()
	{
		return SPI;
	}
	
	// ################## Get SPI #################### //
	
	
	/////////////////////////////////////////////
	
	
	// ################## Set SPI ################### //
	
	public void SetSPI(int set)
	{
		SPI = set;
	}
	public void SetSPI(float set)
	{
		SPI = Extras.Round (set);
	}
	public void SetSPI(double set)
	{
		SPI = Extras.Round (set);
	}
	public void SetSPI(decimal set)
	{
		SPI = Extras.Round (set);
	}
	
	// ################# Set SPI ################### //
	

	//////////////////////////////////////////////////////////////////////////////////////////


	//////////////////////////////////////////////////////////////////////////////////////////


	// ################### Get HPGrowth #################### //
	
	public int GetHPGrowth()
	{
		return HPGrowth;
	}
	
	// ################## Get HPGrowth #################### //
	
	
	/////////////////////////////////////////////
	
	
	// ################## Set HPGrowth ################### //
	
	public void SetHPGrowth(int set)
	{
		HPGrowth = set;
	}
	public void SetHPGrowth(float set)
	{
		HPGrowth = Extras.Round (set);
	}
	public void SetHPGrowth(double set)
	{
		HPGrowth = Extras.Round (set);
	}
	public void SetHPGrowth(decimal set)
	{
		HPGrowth = Extras.Round (set);
	}
	
	// ################# Set HPGrowth ################### //


	//////////////////////////////////////////////////////////////////////////////////////////


	// ################### Get MPGrowth #################### //
	
	public int GetMPGrowth()
	{
		return MPGrowth;
	}
	
	// ################## Get MPGrowth #################### //
	
	
	/////////////////////////////////////////////
	
	
	// ################## Set MPGrowth ################### //
	
	public void SetMPGrowth(int set)
	{
		MPGrowth = set;
	}
	public void SetMPGrowth(float set)
	{
		MPGrowth = Extras.Round (set);
	}
	public void SetMPGrowth(double set)
	{
		MPGrowth = Extras.Round (set);
	}
	public void SetMPGrowth(decimal set)
	{
		MPGrowth = Extras.Round (set);
	}
	
	// ################# Set MPGrowth ################### //


	//////////////////////////////////////////////////////////////////////////////////////////
	

	// ################### Get STRGrowth #################### //
	
	public int GetSTRGrowth()
	{
		return STRGrowth;
	}
	
	// ################## Get STRGrowth #################### //
	
	
	/////////////////////////////////////////////
	
	
	// ################## Set STRGrowth ################### //
	
	public void SetSTRGrowth(int set)
	{
		STRGrowth = set;
	}
	public void SetSTRGrowth(float set)
	{
		STRGrowth = Extras.Round (set);
	}
	public void SetSTRGrowth(double set)
	{
		STRGrowth = Extras.Round (set);
	}
	public void SetSTRGrowth(decimal set)
	{
		STRGrowth = Extras.Round (set);
	}
	
	// ################# Set STRGrowth ################### //
	
	
	//////////////////////////////////////////////////////////////////////////////////////////
	
	
	// ################### Get CONGrowth #################### //
	
	public int GetCONGrowth()
	{
		return CONGrowth;
	}
	
	// ################## Get CONGrowth #################### //
	
	
	/////////////////////////////////////////////
	
	
	// ################## Set CONGrowth ################### //
	
	public void SetCONGrowth(int set)
	{
		CONGrowth = set;
	}
	public void SetCONGrowth(float set)
	{
		CONGrowth = Extras.Round (set);
	}
	public void SetCONGrowth(double set)
	{
		CONGrowth = Extras.Round (set);
	}
	public void SetCONGrowth(decimal set)
	{
		CONGrowth = Extras.Round (set);
	}
	
	// ################# Set CONGrowth ################### //
	
	
	//////////////////////////////////////////////////////////////////////////////////////////
	
	
	// ################### Get AGIGrowth #################### //
	
	public int GetAGIGrowth()
	{
		return AGIGrowth;
	}
	
	// ################## Get AGIGrowth #################### //
	
	
	/////////////////////////////////////////////
	
	
	// ################## Set AGIGrowth ################### //
	
	public void SetAGIGrowth(int set)
	{
		AGIGrowth = set;
	}
	public void SetAGIGrowth(float set)
	{
		AGIGrowth = Extras.Round (set);
	}
	public void SetAGIGrowth(double set)
	{
		AGIGrowth = Extras.Round (set);
	}
	public void SetAGIGrowth(decimal set)
	{
		AGIGrowth = Extras.Round (set);
	}
	
	// ################# Set AGIGrowth ################### //
	
	
	//////////////////////////////////////////////////////////////////////////////////////////
	
	
	// ################### Get DEXGrowth #################### //
	
	public int GetDEXGrowth()
	{
		return DEXGrowth;
	}
	
	// ################## Get DEXGrowth #################### //
	
	
	/////////////////////////////////////////////
	
	
	// ################## Set DEXGrowth ################### //
	
	public void SetDEXGrowth(int set)
	{
		DEXGrowth = set;
	}
	public void SetDEXGrowth(float set)
	{
		DEXGrowth = Extras.Round (set);
	}
	public void SetDEXGrowth(double set)
	{
		DEXGrowth = Extras.Round (set);
	}
	public void SetDEXGrowth(decimal set)
	{
		DEXGrowth = Extras.Round (set);
	}
	
	// ################# Set DEXGrowth ################### //
	
	
	//////////////////////////////////////////////////////////////////////////////////////////
	
	
	// ################### Get MGPGrowth #################### //
	
	public int GetMGPGrowth()
	{
		return MGPGrowth;
	}
	
	// ################## Get MGPGrowth #################### //
	
	
	/////////////////////////////////////////////
	
	
	// ################## Set MGPGrowth ################### //
	
	public void SetMGPGrowth(int set)
	{
		MGPGrowth = set;
	}
	public void SetMGPGrowth(float set)
	{
		MGPGrowth = Extras.Round (set);
	}
	public void SetMGPGrowth(double set)
	{
		MGPGrowth = Extras.Round (set);
	}
	public void SetMGPGrowth(decimal set)
	{
		MGPGrowth = Extras.Round (set);
	}
	
	// ################# Set MGPGrowth ################### //
	
	
	//////////////////////////////////////////////////////////////////////////////////////////
	
	
	// ################### Get SPIGrowth #################### //
	
	public int GetSPIGrowth()
	{
		return SPIGrowth;
	}
	
	// ################## Get SPIGrowth #################### //
	
	
	/////////////////////////////////////////////
	
	
	// ################## Set SPIGrowth ################### //
	
	public void SetSPIGrowth(int set)
	{
		SPIGrowth = set;
	}
	public void SetSPIGrowth(float set)
	{
		SPIGrowth = Extras.Round (set);
	}
	public void SetSPIGrowth(double set)
	{
		SPIGrowth = Extras.Round (set);
	}
	public void SetSPIGrowth(decimal set)
	{
		SPIGrowth = Extras.Round (set);
	}
	
	// ################# Set SPI ################### //
	
	
	//////////////////////////////////////////////////////////////////////////////////////////


	//////////////////////////////////////////////////////////////////////////////////////////
	

	// ################### Get HPAffinity #################### //
	
	public float GetHPAffinity()
	{
		return HPAffinity;
	}
	
	// ################## Get HPAffinity #################### //
	
	
	/////////////////////////////////////////////
	
	
	// ################## Set HPAffinity ################### //
	
	public void SetHPAffinity(int set)
	{
		HPAffinity = set;
	}
	public void SetHPAffinity(float set)
	{
		HPAffinity = Extras.Round (set);
	}
	public void SetHPAffinity(double set)
	{
		HPAffinity = Extras.Round (set);
	}
	public void SetHPAffinity(decimal set)
	{
		HPAffinity = Extras.Round (set);
	}
	
	// ################# Set HPAffinity ################### //
	
	
	//////////////////////////////////////////////////////////////////////////////////////////
	
	
	// ################### Get MPAffinity #################### //
	
	public float GetMPAffinity()
	{
		return MPAffinity;
	}
	
	// ################## Get MPAffinity #################### //
	
	
	/////////////////////////////////////////////
	
	
	// ################## Set MPAffinity ################### //
	
	public void SetMPAffinity(int set)
	{
		MPAffinity = set;
	}
	public void SetMPAffinity(float set)
	{
		MPAffinity = Extras.Round (set);
	}
	public void SetMPAffinity(double set)
	{
		MPAffinity = Extras.Round (set);
	}
	public void SetMPAffinity(decimal set)
	{
		MPAffinity = Extras.Round (set);
	}
	
	// ################# Set MPGrowth ################### //


	//////////////////////////////////////////////////////////////////////////////////////////
	

	// ################### Get STRAffinity #################### //
	
	public float GetSTRAffinity()
	{
		return STRAffinity;
	}
	
	// ################## Get STRAffinity #################### //
	
	
	/////////////////////////////////////////////
	
	
	// ################## Set STRAffinity ################### //
	
	public void SetSTRAffinity(int set)
	{
		STRAffinity = set;
	}
	public void SetSTRAffinity(float set)
	{
		STRAffinity = Extras.Round (set);
	}
	public void SetSTRAffinity(double set)
	{
		STRAffinity = Extras.Round (set);
	}
	public void SetSTRAffinity(decimal set)
	{
		STRAffinity = Extras.Round (set);
	}
	
	// ################# Set STRAffinity ################### //
	
	
	//////////////////////////////////////////////////////////////////////////////////////////
	
	
	// ################### Get CONAffinity #################### //
	
	public float GetCONAffinity()
	{
		return CONAffinity;
	}
	
	// ################## Get CONAffinity #################### //
	
	
	/////////////////////////////////////////////
	
	
	// ################## Set CONAffinity ################### //
	
	public void SetCONAffinity(int set)
	{
		CONAffinity = set;
	}
	public void SetCONAffinity(float set)
	{
		CONAffinity = Extras.Round (set);
	}
	public void SetCONAffinity(double set)
	{
		CONAffinity = Extras.Round (set);
	}
	public void SetCONAffinity(decimal set)
	{
		CONAffinity = Extras.Round (set);
	}
	
	// ################# Set CONAffinity ################### //
	
	
	//////////////////////////////////////////////////////////////////////////////////////////
	
	
	// ################### Get AGIAffinity #################### //
	
	public float GetAGIAffinity()
	{
		return AGIAffinity;
	}
	
	// ################## Get AGIAffinity #################### //
	
	
	/////////////////////////////////////////////
	
	
	// ################## Set AGIAffinity ################### //
	
	public void SetAGIAffinity(int set)
	{
		AGIAffinity = set;
	}
	public void SetAGIAffinity(float set)
	{
		AGIAffinity = Extras.Round (set);
	}
	public void SetAGIAffinity(double set)
	{
		AGIAffinity = Extras.Round (set);
	}
	public void SetAGIAffinity(decimal set)
	{
		AGIAffinity = Extras.Round (set);
	}
	
	// ################# Set AGIAffinity ################### //
	
	
	//////////////////////////////////////////////////////////////////////////////////////////
	
	
	// ################### Get DEXAffinity #################### //
	
	public float GetDEXAffinity()
	{
		return DEXAffinity;
	}
	
	// ################## Get DEXAffinity #################### //
	
	
	/////////////////////////////////////////////
	
	
	// ################## Set DEXAffinity ################### //
	
	public void SetDEXAffinity(int set)
	{
		DEXAffinity = set;
	}
	public void SetDEXAffinity(float set)
	{
		DEXAffinity = Extras.Round (set);
	}
	public void SetDEXAffinity(double set)
	{
		DEXAffinity = Extras.Round (set);
	}
	public void SetDEXAffinity(decimal set)
	{
		DEXAffinity = Extras.Round (set);
	}
	
	// ################# Set DEXAffinity ################### //
	
	
	//////////////////////////////////////////////////////////////////////////////////////////
	
	
	// ################### Get MGPAffinity #################### //
	
	public float GetMGPAffinity()
	{
		return MGPAffinity;
	}
	
	// ################## Get MGPAffinity #################### //
	
	
	/////////////////////////////////////////////
	
	
	// ################## Set MGPAffinity ################### //
	
	public void SetMGPAffinity(int set)
	{
		MGPAffinity = set;
	}
	public void SetMGPAffinity(float set)
	{
		MGPAffinity = Extras.Round (set);
	}
	public void SetMGPAffinity(double set)
	{
		MGPAffinity = Extras.Round (set);
	}
	public void SetMGPAffinity(decimal set)
	{
		MGPAffinity = Extras.Round (set);
	}
	
	// ################# Set MGPAffinity ################### //
	
	
	//////////////////////////////////////////////////////////////////////////////////////////
	
	
	// ################### Get SPIAffinity #################### //
	
	public float GetSPIAffinity()
	{
		return SPIAffinity;
	}
	
	// ################## Get SPIAffinity #################### //
	
	
	/////////////////////////////////////////////
	
	
	// ################## Set SPIAffinity ################### //
	
	public void SetSPIAffinity(int set)
	{
		SPIAffinity = set;
	}
	public void SetSPIAffinity(float set)
	{
		SPIAffinity = Extras.Round (set);
	}
	public void SetSPIAffinity(double set)
	{
		SPIAffinity = Extras.Round (set);
	}
	public void SetSPIAffinity(decimal set)
	{
		SPIAffinity = Extras.Round (set);
	}
	
	// ################# Set SPIAffinity ################### //
	
	
	//////////////////////////////////////////////////////////////////////////////////////////


	//////////////////////////////////////////////////////////////////////////////////////////

}
