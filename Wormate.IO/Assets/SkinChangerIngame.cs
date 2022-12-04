using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinChangerIngame : MonoBehaviour
{
    [Header("Head To Change")]
    [SerializeField] private SpriteRenderer spriteSkin0;

    [Header("1 To Change")]
    [SerializeField] private SpriteRenderer spriteSkin1;

    [Header("2 To Change")]
    [SerializeField] private SpriteRenderer spriteSkin2;

    [Header("3 To Change")]
    [SerializeField] private SpriteRenderer spriteSkin3;

    [Header("4 To Change")]
    [SerializeField] private SpriteRenderer spriteSkin4;

    [Header("5 To Change")]
    [SerializeField] private SpriteRenderer spriteSkin5;
   
    [Header("6 To Change")]
    [SerializeField] private SpriteRenderer spriteSkin6;

    [Header("7 To Change")]
    [SerializeField] private SpriteRenderer spriteSkin7;

    [Header("8 To Change")]
    [SerializeField] private SpriteRenderer spriteSkin8;

    [Header("9 To Change")]
    [SerializeField] private SpriteRenderer spriteSkin9;

    [Header("Styles to Cycle Through")]
    public List<Sprite> SkinOptions = new List<Sprite>();

    [SerializeField] private Color[] colors;
    private int currentSkin = 0;

    private int skinStartsAtIndex;

 
    public void ValidateSkin(int currentSkin)
    {
        switch (currentSkin)
        {
            case 0:
                // Done
                skinStartsAtIndex = 1;
                spriteSkin0.sprite = SkinOptions[25];
                spriteSkin1.sprite = SkinOptions[24];
                spriteSkin2.sprite = SkinOptions[23];
                spriteSkin3.sprite = SkinOptions[22];
                spriteSkin4.sprite = SkinOptions[21];
                spriteSkin5.sprite = SkinOptions[20];
                spriteSkin6.sprite = SkinOptions[2];
                spriteSkin7.sprite = SkinOptions[1];
                spriteSkin8.sprite = SkinOptions[0];
                spriteSkin9.sprite = SkinOptions[25]; 
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[9];
                break;

            case 1:
                // Done
                skinStartsAtIndex = 1;
                spriteSkin0.sprite = SkinOptions[568];
                spriteSkin1.sprite = SkinOptions[567];
                spriteSkin2.sprite = SkinOptions[570];
                spriteSkin3.sprite = SkinOptions[569];
                spriteSkin4.sprite = SkinOptions[5];
                spriteSkin5.sprite = SkinOptions[3];
                spriteSkin6.sprite = SkinOptions[4];
                spriteSkin7.sprite = SkinOptions[570];
                spriteSkin8.sprite = SkinOptions[569];
                spriteSkin9.sprite = SkinOptions[568]; 
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[9];

                break;

            case 2:
                // DONE
                skinStartsAtIndex = 2;
                spriteSkin0.sprite = SkinOptions[9];
                spriteSkin1.sprite = SkinOptions[8];
                spriteSkin2.sprite = SkinOptions[7];
                spriteSkin3.sprite = SkinOptions[6];
                spriteSkin4.sprite = SkinOptions[9];
                spriteSkin5.sprite = SkinOptions[8];
                spriteSkin6.sprite = SkinOptions[7];
                spriteSkin7.sprite = SkinOptions[6];
                spriteSkin8.sprite = SkinOptions[9];
                spriteSkin9.sprite = SkinOptions[8]; 
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[9];

                break;

            case 3:
                // DONE

                skinStartsAtIndex = 2;
                spriteSkin0.sprite = SkinOptions[15];
                spriteSkin1.sprite = SkinOptions[14];
                spriteSkin2.sprite = SkinOptions[13];
                spriteSkin3.sprite = SkinOptions[12];
                spriteSkin4.sprite = SkinOptions[11];
                spriteSkin5.sprite = SkinOptions[10];
                spriteSkin6.sprite = SkinOptions[13];
                spriteSkin7.sprite = SkinOptions[12];
                spriteSkin8.sprite = SkinOptions[15];
                spriteSkin9.sprite = SkinOptions[14]; 
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[9];

                break;

            case 4:
                // DONE
                skinStartsAtIndex = 2;
                spriteSkin0.sprite = SkinOptions[19];
                spriteSkin1.sprite = SkinOptions[18];
                spriteSkin2.sprite = SkinOptions[17];
                spriteSkin3.sprite = SkinOptions[16];
                spriteSkin4.sprite = SkinOptions[19];
                spriteSkin5.sprite = SkinOptions[18];
                spriteSkin6.sprite = SkinOptions[17];
                spriteSkin7.sprite = SkinOptions[16];
                spriteSkin8.sprite = SkinOptions[19];
                spriteSkin9.sprite = SkinOptions[18]; 
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[9];
                break;

            case 5:
                // DONE
                skinStartsAtIndex = 2;
                spriteSkin0.sprite = SkinOptions[29];
                spriteSkin1.sprite = SkinOptions[28];
                spriteSkin2.sprite = SkinOptions[27];
                spriteSkin3.sprite = SkinOptions[26];
                spriteSkin4.sprite = SkinOptions[822];
                spriteSkin5.sprite = SkinOptions[822];
                spriteSkin6.sprite = SkinOptions[822];
                spriteSkin7.sprite = SkinOptions[822];
                spriteSkin8.sprite = SkinOptions[29];
                spriteSkin9.sprite = SkinOptions[28]; 
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[9];
                break;

            case 6:
                // DONE
                skinStartsAtIndex = 2;
                spriteSkin0.sprite = SkinOptions[33];
                spriteSkin1.sprite = SkinOptions[32];
                spriteSkin2.sprite = SkinOptions[31];
                spriteSkin3.sprite = SkinOptions[30];
                spriteSkin4.sprite = SkinOptions[33];
                spriteSkin5.sprite = SkinOptions[32];
                spriteSkin6.sprite = SkinOptions[31];
                spriteSkin7.sprite = SkinOptions[30];
                spriteSkin8.sprite = SkinOptions[33];
                spriteSkin9.sprite = SkinOptions[32]; 
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[9];
                break;

            case 7:
                // DONE
                skinStartsAtIndex = 3;
                spriteSkin0.sprite = SkinOptions[40];
                spriteSkin1.sprite = SkinOptions[39];
                spriteSkin2.sprite = SkinOptions[38];
                spriteSkin3.sprite = SkinOptions[37];
                spriteSkin4.sprite = SkinOptions[36];
                spriteSkin5.sprite = SkinOptions[35];
                spriteSkin6.sprite = SkinOptions[34];
                spriteSkin7.sprite = SkinOptions[40];
                spriteSkin8.sprite = SkinOptions[39];
                spriteSkin9.sprite = SkinOptions[38]; 
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[9];
                break;

            case 8:
                // DONE
                skinStartsAtIndex = 3;
                spriteSkin0.sprite = SkinOptions[47];
                spriteSkin1.sprite = SkinOptions[46];
                spriteSkin2.sprite = SkinOptions[45];
                spriteSkin3.sprite = SkinOptions[44];
                spriteSkin4.sprite = SkinOptions[43];
                spriteSkin5.sprite = SkinOptions[42];
                spriteSkin6.sprite = SkinOptions[41];
                spriteSkin7.sprite = SkinOptions[47];
                spriteSkin8.sprite = SkinOptions[46];
                spriteSkin9.sprite = SkinOptions[45]; 
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[9];
                break;

            case 9:

                // DONE
                skinStartsAtIndex = 5;
                spriteSkin0.sprite = SkinOptions[52];
                spriteSkin1.sprite = SkinOptions[51];
                spriteSkin2.sprite = SkinOptions[50];
                spriteSkin3.sprite = SkinOptions[49];
                spriteSkin4.sprite = SkinOptions[48];
                spriteSkin5.sprite = SkinOptions[52];
                spriteSkin6.sprite = SkinOptions[51];
                spriteSkin7.sprite = SkinOptions[50];
                spriteSkin8.sprite = SkinOptions[49];
                spriteSkin9.sprite = SkinOptions[48]; 
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[9];
                break;

            case 10:
                // DONE
                skinStartsAtIndex = 5;
                spriteSkin0.sprite = SkinOptions[57];
                spriteSkin1.sprite = SkinOptions[56];
                spriteSkin2.sprite = SkinOptions[55];
                spriteSkin3.sprite = SkinOptions[54];
                spriteSkin4.sprite = SkinOptions[53];
                spriteSkin5.sprite = SkinOptions[57];
                spriteSkin6.sprite = SkinOptions[56];
                spriteSkin7.sprite = SkinOptions[55];
                spriteSkin8.sprite = SkinOptions[54];
                spriteSkin9.sprite = SkinOptions[53]; 
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[9];
                break;

            case 11:

                // Done
                skinStartsAtIndex = 2;
                spriteSkin0.sprite = SkinOptions[65];
                spriteSkin1.sprite = SkinOptions[64];
                spriteSkin2.sprite = SkinOptions[63];
                spriteSkin3.sprite = SkinOptions[62];
                spriteSkin4.sprite = SkinOptions[61];
                spriteSkin5.sprite = SkinOptions[60];
                spriteSkin6.sprite = SkinOptions[59];
                spriteSkin7.sprite = SkinOptions[58];
                spriteSkin8.sprite = SkinOptions[65];
                spriteSkin9.sprite = SkinOptions[64]; 
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[9];
                break;

            case 12:
                // Done
                skinStartsAtIndex = 2;
                spriteSkin0.sprite = SkinOptions[73];
                spriteSkin1.sprite = SkinOptions[72];
                spriteSkin2.sprite = SkinOptions[71];
                spriteSkin3.sprite = SkinOptions[70];
                spriteSkin4.sprite = SkinOptions[69];
                spriteSkin5.sprite = SkinOptions[68];
                spriteSkin6.sprite = SkinOptions[67];
                spriteSkin7.sprite = SkinOptions[66];
                spriteSkin8.sprite = SkinOptions[73];
                spriteSkin9.sprite = SkinOptions[72]; 
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[9];
                break;

            case 13:
                // Done
                skinStartsAtIndex = 3;
                spriteSkin0.sprite = SkinOptions[80];
                spriteSkin1.sprite = SkinOptions[79];
                spriteSkin2.sprite = SkinOptions[78];
                spriteSkin3.sprite = SkinOptions[77];
                spriteSkin4.sprite = SkinOptions[76];
                spriteSkin5.sprite = SkinOptions[75];
                spriteSkin6.sprite = SkinOptions[74];
                spriteSkin7.sprite = SkinOptions[80];
                spriteSkin8.sprite = SkinOptions[79];
                spriteSkin9.sprite = SkinOptions[78]; 
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[9];
                break;

            case 14:
                // Done
                skinStartsAtIndex = 3;
                spriteSkin0.sprite = SkinOptions[87];
                spriteSkin1.sprite = SkinOptions[86];
                spriteSkin2.sprite = SkinOptions[85];
                spriteSkin3.sprite = SkinOptions[84];
                spriteSkin4.sprite = SkinOptions[83];
                spriteSkin5.sprite = SkinOptions[82];
                spriteSkin6.sprite = SkinOptions[81];
                spriteSkin7.sprite = SkinOptions[87];
                spriteSkin8.sprite = SkinOptions[86];
                spriteSkin9.sprite = SkinOptions[85]; 
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[9];
                break;

            case 15:
                // Done
                skinStartsAtIndex = 4;
                spriteSkin0.sprite = SkinOptions[93];
                spriteSkin1.sprite = SkinOptions[92];
                spriteSkin2.sprite = SkinOptions[91];
                spriteSkin3.sprite = SkinOptions[90];
                spriteSkin4.sprite = SkinOptions[89];
                spriteSkin5.sprite = SkinOptions[88];
                spriteSkin6.sprite = SkinOptions[93];
                spriteSkin7.sprite = SkinOptions[92];
                spriteSkin8.sprite = SkinOptions[91];
                spriteSkin9.sprite = SkinOptions[90];
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[9];
                break;

            case 16:
                skinStartsAtIndex = 4;
                spriteSkin0.sprite = SkinOptions[99];
                spriteSkin1.sprite = SkinOptions[98];
                spriteSkin2.sprite = SkinOptions[97];
                spriteSkin3.sprite = SkinOptions[96];
                spriteSkin4.sprite = SkinOptions[95];
                spriteSkin5.sprite = SkinOptions[94];
                spriteSkin6.sprite = SkinOptions[99];
                spriteSkin7.sprite = SkinOptions[98];
                spriteSkin8.sprite = SkinOptions[97];
                spriteSkin9.sprite = SkinOptions[96];
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[9];
                break;

            case 17:
                skinStartsAtIndex = 2;
                spriteSkin0.sprite = SkinOptions[103];
                spriteSkin1.sprite = SkinOptions[102];
                spriteSkin2.sprite = SkinOptions[101];
                spriteSkin3.sprite = SkinOptions[100];
                spriteSkin4.sprite = SkinOptions[103];
                spriteSkin5.sprite = SkinOptions[102];
                spriteSkin6.sprite = SkinOptions[101];
                spriteSkin7.sprite = SkinOptions[100];
                spriteSkin8.sprite = SkinOptions[103];
                spriteSkin9.sprite = SkinOptions[102];
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[9];
                break;

            case 18:
                skinStartsAtIndex = 2;
                spriteSkin0.sprite = SkinOptions[824];
                spriteSkin1.sprite = SkinOptions[105];
                spriteSkin2.sprite = SkinOptions[104];
                spriteSkin3.sprite = SkinOptions[824];
                spriteSkin4.sprite = SkinOptions[822];
                spriteSkin5.sprite = SkinOptions[822];
                spriteSkin6.sprite = SkinOptions[822];
                spriteSkin7.sprite = SkinOptions[822];
                spriteSkin8.sprite = SkinOptions[824];
                spriteSkin9.sprite = SkinOptions[105];
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[9];
                break;

            case 19:
                // Schweiz
                skinStartsAtIndex = 2;
                spriteSkin0.sprite = SkinOptions[108];
                spriteSkin1.sprite = SkinOptions[107];
                spriteSkin2.sprite = SkinOptions[106];
                spriteSkin3.sprite = SkinOptions[822];
                spriteSkin4.sprite = SkinOptions[822];
                spriteSkin5.sprite = SkinOptions[822];
                spriteSkin6.sprite = SkinOptions[822];
                spriteSkin7.sprite = SkinOptions[822];
                spriteSkin8.sprite = SkinOptions[108];
                spriteSkin9.sprite = SkinOptions[107];
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[9];
                break;

            case 20:

                skinStartsAtIndex = 1;
                spriteSkin0.sprite = SkinOptions[824];
                spriteSkin1.sprite = SkinOptions[112];
                spriteSkin2.sprite = SkinOptions[111];
                spriteSkin3.sprite = SkinOptions[110];
                spriteSkin4.sprite = SkinOptions[109];
                spriteSkin5.sprite = SkinOptions[824];
                spriteSkin6.sprite = SkinOptions[824];
                spriteSkin7.sprite = SkinOptions[824];
                spriteSkin8.sprite = SkinOptions[824];
                spriteSkin9.sprite = SkinOptions[824];
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[9];
                break;

            case 21:
                // Stern Muster Gelb
                skinStartsAtIndex = 2;
                spriteSkin0.sprite = SkinOptions[120];
                spriteSkin1.sprite = SkinOptions[119];
                spriteSkin2.sprite = SkinOptions[118];
                spriteSkin3.sprite = SkinOptions[117];
                spriteSkin4.sprite = SkinOptions[116];
                spriteSkin5.sprite = SkinOptions[115];
                spriteSkin6.sprite = SkinOptions[114];
                spriteSkin7.sprite = SkinOptions[113];
                spriteSkin8.sprite = SkinOptions[120];
                spriteSkin9.sprite = SkinOptions[119];
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[9];
                break;

            case 22:
                // Stern Muster Pink
                skinStartsAtIndex = 2;
                spriteSkin0.sprite = SkinOptions[128];
                spriteSkin1.sprite = SkinOptions[127];
                spriteSkin2.sprite = SkinOptions[126];
                spriteSkin3.sprite = SkinOptions[125];
                spriteSkin4.sprite = SkinOptions[124];
                spriteSkin5.sprite = SkinOptions[123];
                spriteSkin6.sprite = SkinOptions[122];
                spriteSkin7.sprite = SkinOptions[121];
                spriteSkin8.sprite = SkinOptions[128];
                spriteSkin9.sprite = SkinOptions[127];
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[9];
                break;

            case 23:
                // Stern Muster Orange
                skinStartsAtIndex = 2;
                spriteSkin0.sprite = SkinOptions[136];
                spriteSkin1.sprite = SkinOptions[135];
                spriteSkin2.sprite = SkinOptions[134];
                spriteSkin3.sprite = SkinOptions[133];
                spriteSkin4.sprite = SkinOptions[132];
                spriteSkin5.sprite = SkinOptions[131];
                spriteSkin6.sprite = SkinOptions[130];
                spriteSkin7.sprite = SkinOptions[129];
                spriteSkin8.sprite = SkinOptions[136];
                spriteSkin9.sprite = SkinOptions[135];
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[9];
                break;

            case 24:
                // Stern Muster Blau  Gelb
                skinStartsAtIndex = 2;
                spriteSkin0.sprite = SkinOptions[144];
                spriteSkin1.sprite = SkinOptions[143];
                spriteSkin2.sprite = SkinOptions[142];
                spriteSkin3.sprite = SkinOptions[141];
                spriteSkin4.sprite = SkinOptions[140];
                spriteSkin5.sprite = SkinOptions[139];
                spriteSkin6.sprite = SkinOptions[138];
                spriteSkin7.sprite = SkinOptions[137];
                spriteSkin8.sprite = SkinOptions[144];
                spriteSkin9.sprite = SkinOptions[143];
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[9];
                break;

            case 25:
                // Stern Muster Blau  Gelb
                skinStartsAtIndex = 2;
                spriteSkin0.sprite = SkinOptions[152];
                spriteSkin1.sprite = SkinOptions[151];
                spriteSkin2.sprite = SkinOptions[150];
                spriteSkin3.sprite = SkinOptions[149];
                spriteSkin4.sprite = SkinOptions[148];
                spriteSkin5.sprite = SkinOptions[147];
                spriteSkin6.sprite = SkinOptions[146];
                spriteSkin7.sprite = SkinOptions[145];
                spriteSkin8.sprite = SkinOptions[152];
                spriteSkin9.sprite = SkinOptions[151];
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[9];
                break;

            case 26:
                // Stern Muster Grün klein
                skinStartsAtIndex = 2;
                spriteSkin0.sprite = SkinOptions[160];
                spriteSkin1.sprite = SkinOptions[159];
                spriteSkin2.sprite = SkinOptions[158];
                spriteSkin3.sprite = SkinOptions[157];
                spriteSkin4.sprite = SkinOptions[156];
                spriteSkin5.sprite = SkinOptions[155];
                spriteSkin6.sprite = SkinOptions[154];
                spriteSkin7.sprite = SkinOptions[153];
                spriteSkin8.sprite = SkinOptions[160];
                spriteSkin9.sprite = SkinOptions[159];
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[9];
                break;

            case 27:
                // Stern Muster Orange klein
                skinStartsAtIndex = 2;
                spriteSkin0.sprite = SkinOptions[168];
                spriteSkin1.sprite = SkinOptions[167];
                spriteSkin2.sprite = SkinOptions[166];
                spriteSkin3.sprite = SkinOptions[165];
                spriteSkin4.sprite = SkinOptions[164];
                spriteSkin5.sprite = SkinOptions[163];
                spriteSkin6.sprite = SkinOptions[162];
                spriteSkin7.sprite = SkinOptions[161];
                spriteSkin8.sprite = SkinOptions[168];
                spriteSkin9.sprite = SkinOptions[167];
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[9];
                break;

            case 28:
                // Stern Muster Blau klein
                skinStartsAtIndex = 2;
                spriteSkin0.sprite = SkinOptions[176];
                spriteSkin1.sprite = SkinOptions[175];
                spriteSkin2.sprite = SkinOptions[174];
                spriteSkin3.sprite = SkinOptions[173];
                spriteSkin4.sprite = SkinOptions[172];
                spriteSkin5.sprite = SkinOptions[171];
                spriteSkin6.sprite = SkinOptions[170];
                spriteSkin7.sprite = SkinOptions[169];
                spriteSkin8.sprite = SkinOptions[176];
                spriteSkin9.sprite = SkinOptions[175];
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[9];
                break;

            case 29:
                // Stern Muster Lila klein
                skinStartsAtIndex = 2;
                spriteSkin0.sprite = SkinOptions[184];
                spriteSkin1.sprite = SkinOptions[183];
                spriteSkin2.sprite = SkinOptions[182];
                spriteSkin3.sprite = SkinOptions[181];
                spriteSkin4.sprite = SkinOptions[180];
                spriteSkin5.sprite = SkinOptions[179];
                spriteSkin6.sprite = SkinOptions[178];
                spriteSkin7.sprite = SkinOptions[177];
                spriteSkin8.sprite = SkinOptions[184];
                spriteSkin9.sprite = SkinOptions[183];
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[9];
                break;

            case 30:
                // Kleeblatt
                skinStartsAtIndex = 3;
                spriteSkin0.sprite = SkinOptions[233];
                spriteSkin1.sprite = SkinOptions[232];
                spriteSkin2.sprite = SkinOptions[231];
                spriteSkin3.sprite = SkinOptions[230];
                spriteSkin4.sprite = SkinOptions[229];
                spriteSkin5.sprite = SkinOptions[228];
                spriteSkin6.sprite = SkinOptions[227];
                spriteSkin7.sprite = SkinOptions[233];
                spriteSkin8.sprite = SkinOptions[232];
                spriteSkin9.sprite = SkinOptions[231];
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[9];
                break;

            case 31:
                // Flagge Spanien
                skinStartsAtIndex = 2;
                spriteSkin0.sprite = SkinOptions[258];
                spriteSkin1.sprite = SkinOptions[257];
                spriteSkin2.sprite = SkinOptions[256];
                spriteSkin3.sprite = SkinOptions[255];
                spriteSkin4.sprite = SkinOptions[258];
                spriteSkin5.sprite = SkinOptions[257];
                spriteSkin6.sprite = SkinOptions[256];
                spriteSkin7.sprite = SkinOptions[255];
                spriteSkin8.sprite = SkinOptions[258];
                spriteSkin9.sprite = SkinOptions[257];
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[9];
                break;

            case 32:
                // Flagge Spinnennetz
                skinStartsAtIndex = 2;
                spriteSkin0.sprite = SkinOptions[492];
                spriteSkin1.sprite = SkinOptions[491];
                spriteSkin2.sprite = SkinOptions[490];
                spriteSkin3.sprite = SkinOptions[489];
                spriteSkin4.sprite = SkinOptions[488];
                spriteSkin5.sprite = SkinOptions[487];
                spriteSkin6.sprite = SkinOptions[486];
                spriteSkin7.sprite = SkinOptions[485];
                spriteSkin8.sprite = SkinOptions[492];
                spriteSkin9.sprite = SkinOptions[491];
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[9];
                break;

            case 33:
                // Flagge Geister
                skinStartsAtIndex = 1;
                spriteSkin0.sprite = SkinOptions[523];
                spriteSkin1.sprite = SkinOptions[522];
                spriteSkin2.sprite = SkinOptions[521];
                spriteSkin3.sprite = SkinOptions[520];
                spriteSkin4.sprite = SkinOptions[519];
                spriteSkin5.sprite = SkinOptions[518];
                spriteSkin6.sprite = SkinOptions[517];
                spriteSkin7.sprite = SkinOptions[516];
                spriteSkin8.sprite = SkinOptions[515];
                spriteSkin9.sprite = SkinOptions[523];
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[9];
                break;

            case 34:
                // Waves Grün Lila
                skinStartsAtIndex = 2;
                spriteSkin0.sprite = SkinOptions[548];
                spriteSkin1.sprite = SkinOptions[547];
                spriteSkin2.sprite = SkinOptions[546];
                spriteSkin3.sprite = SkinOptions[545];
                spriteSkin4.sprite = SkinOptions[544];
                spriteSkin5.sprite = SkinOptions[543];
                spriteSkin6.sprite = SkinOptions[542];
                spriteSkin7.sprite = SkinOptions[541];
                spriteSkin8.sprite = SkinOptions[548];
                spriteSkin9.sprite = SkinOptions[547];
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[9];
                break;

            case 35:
                // Waves schwarz Lila
                skinStartsAtIndex = 2;
                spriteSkin0.sprite = SkinOptions[556];
                spriteSkin1.sprite = SkinOptions[555];
                spriteSkin2.sprite = SkinOptions[554];
                spriteSkin3.sprite = SkinOptions[553];
                spriteSkin4.sprite = SkinOptions[552];
                spriteSkin5.sprite = SkinOptions[551];
                spriteSkin6.sprite = SkinOptions[550];
                spriteSkin7.sprite = SkinOptions[549];
                spriteSkin8.sprite = SkinOptions[556];
                spriteSkin9.sprite = SkinOptions[555];
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[9];
                break;

            case 36:
                // Yellow
                spriteSkin9.sprite =
                spriteSkin8.sprite =
                spriteSkin7.sprite =
                spriteSkin6.sprite =
                spriteSkin5.sprite =
                spriteSkin4.sprite =
                spriteSkin3.sprite =
                spriteSkin2.sprite =
                spriteSkin1.sprite =
                spriteSkin0.sprite = SkinOptions[823];
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[0];
                break;

            case 37:
                // Orange
                spriteSkin9.sprite =
 spriteSkin8.sprite =
 spriteSkin7.sprite =
 spriteSkin6.sprite =
 spriteSkin5.sprite =
 spriteSkin4.sprite =
 spriteSkin3.sprite =
 spriteSkin2.sprite =
 spriteSkin1.sprite =
 spriteSkin0.sprite = SkinOptions[823];
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[1];
                break;

            case 38:
                // Red
                spriteSkin9.sprite =
 spriteSkin8.sprite =
 spriteSkin7.sprite =
 spriteSkin6.sprite =
 spriteSkin5.sprite =
 spriteSkin4.sprite =
 spriteSkin3.sprite =
 spriteSkin2.sprite =
 spriteSkin1.sprite =
 spriteSkin0.sprite = SkinOptions[823];
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[2];
                break;

            case 39:
                // Green
                spriteSkin9.sprite =
 spriteSkin8.sprite =
 spriteSkin7.sprite =
 spriteSkin6.sprite =
 spriteSkin5.sprite =
 spriteSkin4.sprite =
 spriteSkin3.sprite =
 spriteSkin2.sprite =
 spriteSkin1.sprite =
 spriteSkin0.sprite = SkinOptions[823];
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[3];
                break;

            case 40:
                // Cyan
                spriteSkin9.sprite =
   spriteSkin8.sprite =
   spriteSkin7.sprite =
   spriteSkin6.sprite =
   spriteSkin5.sprite =
   spriteSkin4.sprite =
   spriteSkin3.sprite =
   spriteSkin2.sprite =
   spriteSkin1.sprite =
   spriteSkin0.sprite = SkinOptions[823];
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[4];
                break;

            case 41:
                // LightBlue
                spriteSkin9.sprite =
 spriteSkin8.sprite =
 spriteSkin7.sprite =
 spriteSkin6.sprite =
 spriteSkin5.sprite =
 spriteSkin4.sprite =
 spriteSkin3.sprite =
 spriteSkin2.sprite =
 spriteSkin1.sprite =
 spriteSkin0.sprite = SkinOptions[823];
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[5];
                break;

            case 42:
                // Blue
                spriteSkin9.sprite =
  spriteSkin8.sprite =
  spriteSkin7.sprite =
  spriteSkin6.sprite =
  spriteSkin5.sprite =
  spriteSkin4.sprite =
  spriteSkin3.sprite =
  spriteSkin2.sprite =
  spriteSkin1.sprite =
  spriteSkin0.sprite = SkinOptions[823];
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[6];
                break;

            case 43:
                // Lila
                spriteSkin9.sprite =
spriteSkin8.sprite =
spriteSkin7.sprite =
spriteSkin6.sprite =
spriteSkin5.sprite =
spriteSkin4.sprite =
spriteSkin3.sprite =
spriteSkin2.sprite =
spriteSkin1.sprite =
spriteSkin0.sprite = SkinOptions[823];
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[7];
                break;

            case 44:
                // White
                spriteSkin9.sprite =
  spriteSkin8.sprite =
  spriteSkin7.sprite =
  spriteSkin6.sprite =
  spriteSkin5.sprite =
  spriteSkin4.sprite =
  spriteSkin3.sprite =
  spriteSkin2.sprite =
  spriteSkin1.sprite =
  spriteSkin0.sprite = SkinOptions[823];
                spriteSkin9.color =
                spriteSkin8.color =
                spriteSkin7.color =
                spriteSkin6.color =
                spriteSkin5.color =
                spriteSkin4.color =
                spriteSkin3.color =
                spriteSkin2.color =
                spriteSkin1.color =
                spriteSkin0.color = colors[8];
                break;
        }
        CharCreation.currentSkinPlayer = currentSkin;
        CharCreation.SkinsStartsPlayer = skinStartsAtIndex;
    }

    private void Set90Degree()
    {
        spriteSkin0.transform.Rotate(0, 0, 90);
        spriteSkin1.transform.Rotate(0, 0, 90);
        spriteSkin2.transform.Rotate(0, 0, 90);
        spriteSkin3.transform.Rotate(0, 0, 90);
        spriteSkin4.transform.Rotate(0, 0, 90);
        spriteSkin5.transform.Rotate(0, 0, 90);
        spriteSkin6.transform.Rotate(0, 0, 90);
        spriteSkin7.transform.Rotate(0, 0, 90);
        spriteSkin8.transform.Rotate(0, 0, 90);
        spriteSkin9.transform.Rotate(0, 0, 90);
    }

    private void Reset90Degree()
    {
        spriteSkin0.transform.Rotate(0, 0, -90);
        spriteSkin1.transform.Rotate(0, 0, -90);
        spriteSkin2.transform.Rotate(0, 0, -90);
        spriteSkin3.transform.Rotate(0, 0, -90);
        spriteSkin4.transform.Rotate(0, 0, -90);
        spriteSkin5.transform.Rotate(0, 0, -90);
        spriteSkin6.transform.Rotate(0, 0, -90);
        spriteSkin7.transform.Rotate(0, 0, -90);
        spriteSkin8.transform.Rotate(0, 0, -90);
        spriteSkin9.transform.Rotate(0, 0, -90);
    }
}