using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mikroprocesor
{
    public static class Procesor
    {
        private static bool[] rejestr = new bool[64]; //4 rejestry po 16 bitów = 64


        // --- adresy pierwszych komórek danych rejestrów
        //AX
        public const byte AH = 0;
        public const byte AL = 8;
        //BX
        public const byte BH = 16;
        public const byte BL = 24;
        //CX
        public const byte CH = 32;
        public const byte CL = 40;
        //DX
        public const byte DH = 48;
        public const byte DL = 56;

        //flagi
        private static bool CF = false; //flaga przeniesienia
        private static bool OF = false; //flaga przepełnienia
        public static bool TF = false; //flaga pracy krokowej



        public static bool jestOF()
        {
            return OF;
        }



        public static void MOV(byte RD, byte RS)
        {
            for (int i = 0; i < 16; i++)
            {
                rejestr[i + RD] = rejestr[i + RS];
            }
            OF = false;
        }
        public static void MOV(byte RD, bool[] C)
        {
            for (int i = 0; i < 16; i++)
            {
                rejestr[i + RD] = C[i];
            }
            OF = false;
        }
        public static void ADD(byte RS)
        {
            for (int i = 15; i >= 0; i--)
            {
                if (CF)
                {
                    if (rejestr[i + AH] || rejestr[i + RS]) //gdy jest chociaz jedna 1
                    {
                        if (rejestr[i + AH] && rejestr[i + RS]) //gry 1+1
                        {
                            rejestr[i + AH] = true; //1+1+1=11, więc 1 (true) wyniku i przeniesienie 1
                            CF = true;
                        }
                        else
                        {
                            rejestr[i + AH] = false; //1+0+1=10, więc 0 (false) wyniku i przeniesienie 1
                            CF = true;
                        }
                    }
                    else
                    {
                        rejestr[i + AH] = true; //0+0+1=1, więc 1 (true) wyniku i przeniesienie 0
                        CF = false;
                    }
                }
                else
                {
                    if (rejestr[i + AH] || rejestr[i + RS]) //gdy jest chociaz jedna 1
                    {
                        if (rejestr[i + AH] && rejestr[i + RS]) //gry 1+1
                        {
                            rejestr[i + AH] = false; //1+1=10, więc 0 (false) wyniku i przeniesienie 1
                            CF = true;
                        }
                        else
                        {
                            rejestr[i + AH] = true; //1+0=1, więc 1 (true) wyniku i przeniesienie 0
                            CF = false;
                        }
                    }
                    else
                    {
                        rejestr[i + AH] = false; //0+0=0, więc 0 (false) wyniku i przeniesienie 0
                        CF = false;
                    }
                }




            }
            if (CF)
            {
                CF = false;
                OF = true;
                for (int i = 15; i >= 0; i--)
                {
                    rejestr[i + AH] = true;
                }

            }
            else OF = false;
        }

        public static void ADD(bool[] liczba)
        {
            for (int i = 15; i >= 0; i--)
            {
                if (CF)
                {
                    if (rejestr[i + AH] || liczba[i]) //gdy jest chociaz jedna 1
                    {
                        if (rejestr[i + AH] && liczba[i]) //gry 1+1
                        {
                            rejestr[i + AH] = true; //1+1+1=11, więc 1 (true) wyniku i przeniesienie 1
                            CF = true;
                        }
                        else
                        {
                            rejestr[i + AH] = false; //1+0+1=10, więc 0 (false) wyniku i przeniesienie 1
                            CF = true;
                        }
                    }
                    else
                    {
                        rejestr[i + AH] = true; //0+0+1=1, więc 1 (true) wyniku i przeniesienie 0
                        CF = false;
                    }
                }
                else
                {
                    if (rejestr[i + AH] || liczba[i]) //gdy jest chociaz jedna 1
                    {
                        if (rejestr[i + AH] && liczba[i]) //gry 1+1
                        {
                            rejestr[i + AH] = false; //1+1=10, więc 0 (false) wyniku i przeniesienie 1
                            CF = true;
                        }
                        else
                        {
                            rejestr[i + AH] = true; //1+0=1, więc 1 (true) wyniku i przeniesienie 0
                            CF = false;
                        }
                    }
                    else
                    {
                        rejestr[i + AH] = false; //0+0=0, więc 0 (false) wyniku i przeniesienie 0
                        CF = false;
                    }
                }




            }
            if (CF)
            {
                CF = false;
                OF = true;
                for (int i = 15; i >= 0; i--)
                {
                    rejestr[i + AH] = true;
                }

            }
            else OF = false;
        }

        public static void SUB(byte RS)
        {
            for (int i = 15; i >= 0; i--)
            {
                if (CF)
                {
                    if (rejestr[i + AH] || rejestr[i + RS]) //gdy jest chociaz jedna 1
                    {
                        if (rejestr[i + AH] && rejestr[i + RS]) //gry 1-1
                        {
                            rejestr[i + AH] = true; //10-1-1=1, więc 1 (true) wyniku i przeniesienie 1
                            CF = true;
                        }
                        else
                        {
                            if (rejestr[i + AH])
                            {
                                rejestr[i + AH] = false; //1-0-1=0, więc 0 (false) wyniku i przeniesienie 0
                                CF = false;
                            }
                            else
                            {
                                rejestr[i + AH] = false; //10-1-1=0, więc 0 (false) wyniku i przeniesienie 1
                                CF = true;
                            }

                        }
                    }
                    else
                    {
                        rejestr[i + AH] = true; //10-0-1=1, więc 1 (true) wyniku i przeniesienie 1
                        CF = true;
                    }
                }
                else
                {
                    if (rejestr[i + AH] || rejestr[i + RS]) //gdy jest chociaz jedna 1
                    {
                        if (rejestr[i + AH] && rejestr[i + RS]) //gry 1-1
                        {
                            rejestr[i + AH] = false; //1-1=0, więc 0 (false) wyniku i przeniesienie 0
                            CF = false;
                        }
                        else
                        {
                            if (rejestr[i + AH])
                            {
                                rejestr[i + AH] = true; //1-0=1, więc 1 (true) wyniku i przeniesienie 0
                                CF = false;
                            }
                            else
                            {
                                rejestr[i + AH] = true; //10-1=1, więc 1 (true) wyniku i przeniesienie 1
                                CF = true;
                            }

                        }
                    }
                    else
                    {
                        rejestr[i + AH] = false; //0-0=0, więc 0 (false) wyniku i przeniesienie 0
                        CF = false;
                    }
                }




            }
            if (CF)
            {
                CF = false;
                OF = true;
                for (int i = 15; i >= 0; i--)
                {
                    rejestr[i + AH] = false;
                }

            }
            else OF = false;
        }

        public static void SUB(bool[] liczba)
        {
            for (int i = 15; i >= 0; i--)
            {
                if (CF)
                {
                    if (rejestr[i + AH] || liczba[i]) //gdy jest chociaz jedna 1
                    {
                        if (rejestr[i + AH] && liczba[i]) //gry 1-1
                        {
                            rejestr[i + AH] = true; //10-1-1=1, więc 1 (true) wyniku i przeniesienie 1
                            CF = true;
                        }
                        else
                        {
                            if (rejestr[i + AH])
                            {
                                rejestr[i + AH] = false; //1-0-1=0, więc 0 (false) wyniku i przeniesienie 0
                                CF = false;
                            }
                            else
                            {
                                rejestr[i + AH] = false; //10-1-1=0, więc 0 (false) wyniku i przeniesienie 1
                                CF = true;
                            }

                        }
                    }
                    else
                    {
                        rejestr[i + AH] = true; //10-0-1=1, więc 1 (true) wyniku i przeniesienie 1
                        CF = true;
                    }
                }
                else
                {
                    if (rejestr[i + AH] || liczba[i]) //gdy jest chociaz jedna 1
                    {
                        if (rejestr[i + AH] && liczba[i]) //gry 1-1
                        {
                            rejestr[i + AH] = false; //1-1=0, więc 0 (false) wyniku i przeniesienie 0
                            CF = false;
                        }
                        else
                        {
                            if (rejestr[i + AH])
                            {
                                rejestr[i + AH] = true; //1-0=1, więc 1 (true) wyniku i przeniesienie 0
                                CF = false;
                            }
                            else
                            {
                                rejestr[i + AH] = true; //10-1=1, więc 1 (true) wyniku i przeniesienie 1
                                CF = true;
                            }

                        }
                    }
                    else
                    {
                        rejestr[i + AH] = false; //0-0=0, więc 0 (false) wyniku i przeniesienie 0
                        CF = false;
                    }
                }




            }
            if (CF)
            {
                CF = false;
                OF = true;
                for (int i = 15; i >= 0; i--)
                {
                    rejestr[i + AH] = false;
                }

            }
            else OF = false;
        }



        public static string rejestrJakoTekst(byte adresRejestru)
        {
            string buff = "";
            for (int i = 0; i < 8; i++)
            {
                if (rejestr[i + adresRejestru]) buff += "1"; //gdy dany bit to "true" (1), dopisz 1
                else buff += "0"; //jesli nie to 0;
            }
            return buff;
        }

        public static string zerujUstawienia(byte adresRejestru2)
        {
            string buff = "";
            for (int i = 0; i < 8; i++)
            {
                if (rejestr[adresRejestru2]) buff += "0";
                else buff += "0";
            }
            return buff;
        }
    }

    static class TextControllClass
    {

        public static string TextControll(string textBoxValue)
        {
            if (textBoxValue.Length != 0)
            {

                string buff = "";

                for (int i = 0; i < textBoxValue.Length; i++)
                {
                    if (i < 16)
                    {
                        if (textBoxValue[i].Equals('1') || textBoxValue[i].Equals('0'))
                        {
                            buff += textBoxValue[i];
                        }
                    }
                }

                textBoxValue = buff;
            }
            return textBoxValue;


        }

        public static bool charToBool(char bit)
        {
            if (bit.Equals('1')) return true;
            else return false;
        }

        public static bool[] textToNumber(string text)
        {
            bool[] tymcz = new bool[16];
            for (int i = 0; i < 16; i++)
            {
                if (i < text.Length) tymcz[15 - i] = charToBool(text[text.Length - 1 - i]);
                else tymcz[15 - i] = false;



            }
            return tymcz;
        }
    }
}
