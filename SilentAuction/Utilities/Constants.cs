namespace SilentAuction.Utilities
{
    public class Constants
    {
        public static int MaxNumberOfLines = 20;
        public static byte[] EmptyImage = 
        {
            137, 80, 78, 71, 13, 10, 26, 10, 0, 0, 0, 13, 73, 72, 68, 82, 0, 0, 0, 1, 0, 0, 0, 
            1, 8, 6, 0, 0, 0, 31, 21, 196, 137, 0, 0, 0, 1, 115, 82, 71, 66, 0, 174, 206, 28, 
            233, 0, 0, 0, 4, 103, 65, 77, 65, 0, 0, 177, 143, 11, 252, 97, 5, 0, 0, 0, 9, 112, 
            72, 89, 115, 0, 0, 14, 195, 0, 0, 14, 195, 1, 199, 111, 168, 100, 0, 0, 0, 11, 73, 
            68, 65, 84, 24, 87, 99, 96, 0, 2, 0, 0, 5, 0, 1, 170, 213, 200, 81, 0, 0, 0, 0, 73, 
            69, 78, 68, 174, 66, 96, 130
        };

        public const string ItemNumber = "<<ItemNumber>>";
        public const string RetailValue = "<<RetailValue>>";
        public const string BidList = "<<BidList>>";
        public const string BuyItNowValue = "<<BuyItNow>>";
        public const string AuctionName = "<<AuctionName>>";
        public const string ItemName = "<<ItemName>>";
        public const string ItemDescription = "<<ItemDescription>>";
        public const string DonorName = "<<DonorName>>";


        public const string Company = "<<CompanyName>>";
        public const string ContactName = "<<ContactName>>";
        public const string Street1 = "<<Street1>>";
        public const string Street2 = "<<Street2>>";
        public const string City = "<<City>>";
        public const string State = "<<State>>";
        public const string ZipCode = "<<ZipCode>>";


        public static string BidSheetRtf =
@"{\rtf1\ansi\ansicpg1252\uc1\deff1\adeff1\deflang0\deflangfe0\adeflang0{\fonttbl
{\f0\fnil\fcharset0\fprq2 Arial;}
{\f1\fswiss\fcharset0\fprq2 Calibri;}
{\f2\fswiss\fcharset0\fprq2 Tahoma;}
{\f3\froman\fcharset0\fprq2 Times New Roman;}
{\f4\fswiss\fcharset0\fprq2 Arial;}
{\f5\fscript\fcharset0\fprq2 Lucida Calligraphy;}
{\f6\froman\fcharset2\fprq2 Symbol;}}
{\colortbl;\red79\green129\blue189;\red0\green0\blue255;\red128\green0\blue128;\red23\green54\blue93;\red242\green242\blue242;\red255\green255\blue255;}
{\stylesheet{\s0\ltrpar\itap0\widctlpar\ql\li0\ri0\lin0\rin0\rtlch\af1\afs22\ltrch\f1\fs22 Normal;}{\*\cs10\additive Default Paragraph Font;}{\s16\ltrpar\itap0\nowidctlpar\ql\li0\ri0\lin0\rin0\rtlch\af0\afs24\ltrch\f0\fs24 [Normal];}{\s17\ltrpar\itap0\widctlpar\ql\li0\ri0\lin0\rin0\rtlch\af2\afs16\ltrch\f2\fs16\sbasedon0 Balloon Text;}{\s18\ltrpar\itap0\widctlpar\ql\li936\ri936\lin936\rin936\sb200\sa280\sl276\slmult1\brdrb\brdrs\brdrw10\brsp80\rtlch\af3\afs22\ab\ai\acf1\ltrch\f3\fs22\b\i\cf1\sbasedon0\snext0 Intense Quote;}{\*\cs19\rtlch\af2\afs16\ltrch\f2\fs16\additive\sbasedon10 Balloon Text Char;}{\*\cs20\rtlch\af3\ab\ai\acf1\ltrch\f3\b\i\cf1\additive\sbasedon10 Intense Quote Char;}{\*\cs21\rtlch\af3\aul\acf2\ltrch\f3\ul\cf2\additive\sbasedon10 Hyperlink;}{\*\cs22\rtlch\af3\aul\acf3\ltrch\f3\ul\cf3\additive\sbasedon10 FollowedHyperlink;}}
{\*\generator TX_RTF32 21.0.551.501;}
\paperw12240\paperh15840\margl1440\margt1440\margr1440\margb1440\deftab1134\widowctrl\lytexcttp\formshade\sectd
\headery720\footery720\pgwsxn12240\pghsxn15840\marglsxn951\margtsxn1037\margrsxn1440\margbsxn404\pgbrdropt0\pgbrdrhead\pgbrdrfoot\pard\ltrpar\itap0\widctlpar\ql\li0\ri0\lin0\rin0\tx720\tx1440\tx2160\tx2880\tx3600\tx4320\tx5040\tx5760\tx6480\tx7200\tx7920\tx8640\tx9360\tx10080\plain\rtlch\af1\afs22\alang1033\ltrch\f1\fs22\lang1033\langnp1033\langfe1033\langfenp1033

{\shp{\*\shpinst\shpleft8701\shptop7\shpright10216\shpbottom457\shpfhdr0\shpbxcolumn\shpbxignore\shpbypara\shpbyignore\shpwr3\shpz3\shplid1026{\sp{\sn shapeType}{\sv 202}}{\sp{\sn fFlipH}{\sv 0}}{\sp{\sn fFlipV}{\sv 0}}{\sp{\sn wzName}{\sv _tx_id_1_Text Box 2}}{\sp{\sn fillColor}{\sv 16777215}}{\sp{\sn fRecolorFillAsPicture}{\sv 0}}{\sp{\sn fFilled}{\sv 1}}{\sp{\sn fLayoutInCell}{\sv 1}}
{\shptxt\pard\ltrpar\itap0\widctlpar\ql\li0\ri0\lin0\rin0\tx720\tx1440\tx2160\tx2880\tx3600\tx4320\tx5040\tx5760\tx6480\tx7200\tx7920\tx8640\tx9360\tx10080\plain\rtlch\af1\afs22\alang1033\ltrch\f1\fs22\lang1033\langnp1033\langfe1033\langfenp1033 Item #  \plain\rtlch\af1\afs22\alang1033\ltrch\f1\fs22\lang1033\langnp1033\langfe1033\langfenp1033{\txfielddef{\*\txfieldstart\txfieldtype0\txfieldflags152\txfielddataval1\txfielddata 
3c003c004900740065006d004e0075006d006200650072003e003e000000}{\*\txfieldtext <<ItemNumber>>{\*\txfieldend}}<<ItemNumber>>}\par}}}

{\shp{\*\shpinst\shpleft-6\shptop0\shpright8184\shpbottom810\shpfhdr0\shpbxcolumn\shpbxignore\shpbypara\shpbyignore\shpwr3\shpz2\shplid1027{\sp{\sn shapeType}{\sv 202}}{\sp{\sn fFlipH}{\sv 0}}{\sp{\sn fFlipV}{\sv 0}}{\sp{\sn wzName}{\sv _tx_id_2_Text Box 2}}{\sp{\sn fillColor}{\sv 16777215}}{\sp{\sn fRecolorFillAsPicture}{\sv 0}}{\sp{\sn fFilled}{\sv 1}}{\sp{\sn dxTextLeft}{\sv 0}}{\sp{\sn dyTextTop}{\sv 0}}{\sp{\sn dxTextRight}{\sv 0}}{\sp{\sn dyTextBottom}{\sv 0}}{\sp{\sn fLine}{\sv 0}}{\sp{\sn fLayoutInCell}{\sv 1}}
{\shptxt\pard\ltrpar\itap0\widctlpar\ql\li0\ri0\lin0\rin0\tx720\tx1440\tx2160\tx2880\tx3600\tx4320\tx5040\tx5760\tx6480\tx7200\tx7920\tx8640\tx9360\tx10080\plain\rtlch\af5\afs48\alang1033\ab\ltrch\f5\fs48\lang1033\langnp1033\langfe1033\langfenp1033\b{\txfielddef{\*\txfieldstart\txfieldtype0\txfieldflags152\txfielddata 
3c003c00410075006300740069006f006e004e0061006d0065003e003e000000}{\*\txfieldtext <<AuctionName>>{\*\txfieldend}}<<AuctionName>>}\par}}}\par\par\par

{\shp{\*\shpinst\shpleft1\shptop41\shpright10220\shpbottom1856\shpfhdr0\shpbxcolumn\shpbxignore\shpbypara\shpbyignore\shpwr3\shpz0\shplid1028{\sp{\sn shapeType}{\sv 202}}{\sp{\sn fFlipH}{\sv 0}}{\sp{\sn fFlipV}{\sv 0}}{\sp{\sn wzName}{\sv _tx_id_3_Text Box 2}}{\sp{\sn fillColor}{\sv 15853019}}{\sp{\sn fRecolorFillAsPicture}{\sv 0}}{\sp{\sn fFilled}{\sv 1}}{\sp{\sn fLayoutInCell}{\sv 1}}
{\shptxt\pard\ltrpar\itap0\widctlpar\ql\li0\ri0\lin0\rin0\tx720\tx1440\tx2160\tx2880\tx3600\tx4320\tx5040\tx5760\tx6480\tx7200\tx7920\tx8640\tx9360\tx10080\plain\rtlch\af4\afs32\alang1033\ab\ltrch\f4\fs32\lang1033\langnp1033\langfe1033\langfenp1033\b{\txfielddef{\*\txfieldstart\txfieldtype0\txfieldflags152\txfielddataval2\txfielddata 
3c003c004900740065006d004e0061006d0065003e003e000000}{\*\txfieldtext <<ItemName>>{\*\txfieldend}}<<ItemName>>}\plain\rtlch\af4\afs32\alang1033\ab\ltrch\f4\fs32\lang1033\langnp1033\langfe1033\langfenp1033\b\par\plain\rtlch\af4\afs24\alang1033\ltrch\f4\fs24\lang1033\langnp1033\langfe1033\langfenp1033{\txfielddef{\*\txfieldstart\txfieldtype0\txfieldflags152\txfielddataval3\txfielddata 
3c003c004900740065006d004400650073006300720069007000740069006f006e003e003e000000}{\*\txfieldtext <<ItemDescription>>{\*\txfieldend}}<<ItemDescription>>}\plain\rtlch\af4\afs24\alang1033\ltrch\f4\fs24\lang1033\langnp1033\langfe1033\langfenp1033\par\par\par\plain\rtlch\af4\afs20\alang1033\ltrch\f4\fs20\lang1033\langnp1033\langfe1033\langfenp1033 Donated By:\plain\rtlch\af4\afs24\alang1033\ltrch\f4\fs24\lang1033\langnp1033\langfe1033\langfenp1033   \plain\rtlch\af4\afs24\alang1033\ab\aul\ltrch\f4\fs24\lang1033\langnp1033\langfe1033\langfenp1033\b\ul{\txfielddef{\*\txfieldstart\txfieldtype0\txfieldflags152\txfielddataval5\txfielddata 
3c003c0044006f006e006f0072004e0061006d0065003e003e000000}{\*\txfieldtext <<DonorName>>{\*\txfieldend}}<<DonorName>>}\par}}}
\par\par\par\par

{\shp{\*\shpinst\shpleft7066\shptop210\shpright10096\shpbottom675\shpfhdr0\shpbxcolumn\shpbxignore\shpbypara\shpbyignore\shpwr3\shpz1\shplid1028{\sp{\sn shapeType}{\sv 202}}{\sp{\sn fFlipH}{\sv 0}}{\sp{\sn fFlipV}{\sv 0}}{\sp{\sn wzName}{\sv _tx_id_4_Text Box 2}}{\sp{\sn fillColor}{\sv 16777215}}{\sp{\sn fRecolorFillAsPicture}{\sv 0}}{\sp{\sn fFilled}{\sv 1}}{\sp{\sn fLayoutInCell}{\sv 1}}
{\shptxt\pard\ltrpar\itap0\widctlpar\qr\li0\ri0\lin0\rin0\tx720\tx1440\tx2160\tx2880\tx3600\tx4320\tx5040\tx5760\tx6480\tx7200\tx7920\tx8640\tx9360\tx10080\plain\rtlch\af5\afs20\alang1033\ab\acf4\ltrch\f4\fs20\lang1033\langnp1033\langfe1033\langfenp1033\b\cf4 Retail Value:  \plain\rtlch\af5\afs24\alang1033\ab\ltrch\f5\fs24\lang1033\langnp1033\langfe1033\langfenp1033\b{\txfielddef{\*\txfieldstart\txfieldtype0\txfieldflags152\txfielddataval4\txfielddata 
3c003c00520065007400610069006c00560061006c00750065003e003e000000}{\*\txfieldtext <<RetailValue>>{\*\txfieldend}}<<RetailValue>>}\par}}}

\par\par\par

\trowd\irow0\irowband0\lastrow\trgaph108\trrh437\trleft0\trftsWidth1\trftsWidthB3\trftsWidthA3\trpaddl108\trpaddr108\trpaddfl3\trpaddft3\trpaddfr3\trpaddfb3\clvertalt\clbrdrl\brdrs\brdrw10\clbrdrt\brdrs\brdrw10\clbrdrr\brdrs\brdrw10\clbrdrb\brdrs\brdrw10\clcbpat5\clftsWidth3\clwWidth1014\cellx1014\clvertalt\clbrdrl\brdrs\brdrw10\clbrdrt\brdrs\brdrw10\clbrdrr\brdrs\brdrw10\clbrdrb\brdrs\brdrw10\clcbpat5\clftsWidth3\clwWidth3054\cellx4068\clvertalt\clbrdrl\brdrs\brdrw10\clbrdrt\brdrs\brdrw10\clbrdrr\brdrs\brdrw10\clbrdrb\brdrs\brdrw10\clcbpat5\clftsWidth3\clwWidth3521\cellx7589\clvertalt\clbrdrl\brdrs\brdrw10\clbrdrt\brdrs\brdrw10\clbrdrr\brdrs\brdrw10\clbrdrb\brdrs\brdrw10\clcbpat5\clftsWidth3\clwWidth2635\cellx10224\pard\ltrpar\intbl\widctlpar\ql\li0\ri0\lin0\rin0\tx720\tx1440\tx2160\tx2880\tx3600\tx4320\tx5040\tx5760\tx6480\tx7200\tx7920\tx8640\tx9360\tx10080\plain\rtlch\af4\afs24\alang1033\ab\ltrch\f4\fs24\lang1033\langnp1033\langfe1033\langfenp1033\b Bid\cell\pard\ltrpar\intbl\widctlpar\qc\li0\ri0\lin0\rin0\tx720\tx1440\tx2160\tx2880\tx3600\tx4320\tx5040\tx5760\tx6480\tx7200\tx7920\tx8640\tx9360\tx10080 Bidder Name\cell Email\cell Phone\cell
\trowd\irow0\irowband0\lastrow\trgaph108\trrh437\trleft0\trftsWidth1\trftsWidthB3\trftsWidthA3\trpaddl108\trpaddr108\trpaddfl3\trpaddft3\trpaddfr3\trpaddfb3\clvertalt\clbrdrl\brdrs\brdrw10\clbrdrt\brdrs\brdrw10\clbrdrr\brdrs\brdrw10\clbrdrb\brdrs\brdrw10\clcbpat5\clftsWidth3\clwWidth1014\cellx1014\clvertalt\clbrdrl\brdrs\brdrw10\clbrdrt\brdrs\brdrw10\clbrdrr\brdrs\brdrw10\clbrdrb\brdrs\brdrw10\clcbpat5\clftsWidth3\clwWidth3054\cellx4068\clvertalt\clbrdrl\brdrs\brdrw10\clbrdrt\brdrs\brdrw10\clbrdrr\brdrs\brdrw10\clbrdrb\brdrs\brdrw10\clcbpat5\clftsWidth3\clwWidth3521\cellx7589\clvertalt\clbrdrl\brdrs\brdrw10\clbrdrt\brdrs\brdrw10\clbrdrr\brdrs\brdrw10\clbrdrb\brdrs\brdrw10\clcbpat5\clftsWidth3\clwWidth2635\cellx10224\row
<<BidList>>


\pard\ltrpar\itap0\widctlpar\ql\li0\ri0\lin0\rin0\tx720\tx1440\tx2160\tx2880\tx3600\tx4320\tx5040\tx5760\tx6480\tx7200\tx7920\tx8640\tx9360\tx10080

{\shp{\*\shpinst\shpleft-59\shptop9131\shpright10171\shpbottom11066\shpfhdr0\shpbxcolumn\shpbxignore\shpbypara\shpbyignore\shpwr3\shpz3\shplid1029{\sp{\sn shapeType}{\sv 202}}{\sp{\sn fFlipH}{\sv 0}}{\sp{\sn fFlipV}{\sv 0}}{\sp{\sn wzName}{\sv _tx_id_4_Text Box 2}}{\sp{\sn fillColor}{\sv 15853019}}{\sp{\sn fRecolorFillAsPicture}{\sv 0}}{\sp{\sn fFilled}{\sv 1}}{\sp{\sn fLayoutInCell}{\sv 1}}
{\shptxt\pard\ltrpar\itap0\widctlpar\ql\li0\ri0\lin0\rin0\tx720\tx1440\tx2160\tx2880\tx3600\tx4320\tx5040\tx5760\tx6480\tx7200\tx7920\tx8640\tx9360\tx10080\plain\rtlch\af4\afs32\alang1033\ab\ltrch\f4\fs32\lang1033\langnp1033\langfe1033\langfenp1033\b Buy Now for: \plain\rtlch\af4\afs32\alang1033\ab\ltrch\f4\fs32\lang1033\langnp1033\langfe1033\langfenp1033\b{\txfielddef{\*\txfieldstart\txfieldtype0\txfieldflags152\txfielddataval6\txfielddata 
3c003c00420075007900490074004e006f0077003e003e000000}{\*\txfieldtext <<BuyItNow>>{\*\txfieldend}}<<BuyItNow>>}\plain\rtlch\af4\afs32\alang1033\ab\ltrch\f4\fs32\lang1033\langnp1033\langfe1033\langfenp1033\b\par\plain\rtlch\af4\afs24\alang1033\ltrch\f4\fs24\lang1033\langnp1033\langfe1033\langfenp1033\par\trowd\irow0\irowband0\trgaph108\trrh437\trleft0\trftsWidth1\trftsWidthB3\trftsWidthA3\trpaddl108\trpaddr108\trpaddfl3\trpaddft3\trpaddfr3\trpaddfb3\clvertalt\clbrdrl\brdrs\brdrw10\clbrdrt\brdrs\brdrw10\clbrdrr\brdrs\brdrw10\clbrdrb\brdrs\brdrw10\clcbpat5\clftsWidth3\clwWidth4623\cellx4623\clvertalt\clbrdrl\brdrs\brdrw10\clbrdrt\brdrs\brdrw10\clbrdrr\brdrs\brdrw10\clbrdrb\brdrs\brdrw10\clcbpat5\clftsWidth3\clwWidth2307\cellx6930\clvertalt\clbrdrl\brdrs\brdrw10\clbrdrt\brdrs\brdrw10\clbrdrr\brdrs\brdrw10\clbrdrb\brdrs\brdrw10\clcbpat5\clftsWidth3\clwWidth2988\cellx9918\pard\ltrpar\intbl\widctlpar\qc\li0\ri0\lin0\rin0\tx720\tx1440\tx2160\tx2880\tx3600\tx4320\tx5040\tx5760\tx6480\tx7200\tx7920\tx8640\tx9360\tx10080\plain\rtlch\af4\afs24\alang1033\ab\ltrch\f4\fs24\lang1033\langnp1033\langfe1033\langfenp1033\b Buyer Name\cell Email\cell Phone\cell\trowd\irow0\irowband0\trgaph108\trrh437\trleft0\trftsWidth1\trftsWidthB3\trftsWidthA3\trpaddl108\trpaddr108\trpaddfl3\trpaddft3\trpaddfr3\trpaddfb3\clvertalt\clbrdrl\brdrs\brdrw10\clbrdrt\brdrs\brdrw10\clbrdrr\brdrs\brdrw10\clbrdrb\brdrs\brdrw10\clcbpat5\clftsWidth3\clwWidth4623\cellx4623\clvertalt\clbrdrl\brdrs\brdrw10\clbrdrt\brdrs\brdrw10\clbrdrr\brdrs\brdrw10\clbrdrb\brdrs\brdrw10\clcbpat5\clftsWidth3\clwWidth2307\cellx6930\clvertalt\clbrdrl\brdrs\brdrw10\clbrdrt\brdrs\brdrw10\clbrdrr\brdrs\brdrw10\clbrdrb\brdrs\brdrw10\clcbpat5\clftsWidth3\clwWidth2988\cellx9918\row\trowd\irow1\irowband1\lastrow\trgaph108\trrh443\trleft0\trftsWidth1\trftsWidthB3\trftsWidthA3\trpaddl108\trpaddr108\trpaddfl3\trpaddft3\trpaddfr3\trpaddfb3\clvertalt\clbrdrl\brdrs\brdrw10\clbrdrt\brdrs\brdrw10\clbrdrr\brdrs\brdrw10\clbrdrb\brdrs\brdrw10\clcbpat6\clftsWidth3\clwWidth4623\cellx4623\clvertalt\clbrdrl\brdrs\brdrw10\clbrdrt\brdrs\brdrw10\clbrdrr\brdrs\brdrw10\clbrdrb\brdrs\brdrw10\clcbpat6\clftsWidth3\clwWidth2307\cellx6930\clvertalt\clbrdrl\brdrs\brdrw10\clbrdrt\brdrs\brdrw10\clbrdrr\brdrs\brdrw10\clbrdrb\brdrs\brdrw10\clcbpat6\clftsWidth3\clwWidth2988\cellx9918\pard\ltrpar\intbl\widctlpar\ql\li0\ri0\lin0\rin0\tx720\tx1440\tx2160\tx2880\tx3600\tx4320\tx5040\tx5760\tx6480\tx7200\tx7920\tx8640\tx9360\tx10080\plain\rtlch\af4\afs24\alang1033\ltrch\f4\fs24\lang1033\langnp1033\langfe1033\langfenp1033\cell\cell\cell\trowd\irow1\irowband1\lastrow\trgaph108\trrh443\trleft0\trftsWidth1\trftsWidthB3\trftsWidthA3\trpaddl108\trpaddr108\trpaddfl3\trpaddft3\trpaddfr3\trpaddfb3\clvertalt\clbrdrl\brdrs\brdrw10\clbrdrt\brdrs\brdrw10\clbrdrr\brdrs\brdrw10\clbrdrb\brdrs\brdrw10\clcbpat6\clftsWidth3\clwWidth4623\cellx4623\clvertalt\clbrdrl\brdrs\brdrw10\clbrdrt\brdrs\brdrw10\clbrdrr\brdrs\brdrw10\clbrdrb\brdrs\brdrw10\clcbpat6\clftsWidth3\clwWidth2307\cellx6930\clvertalt\clbrdrl\brdrs\brdrw10\clbrdrt\brdrs\brdrw10\clbrdrr\brdrs\brdrw10\clbrdrb\brdrs\brdrw10\clcbpat6\clftsWidth3\clwWidth2988\cellx9918\row\pard\ltrpar\itap0\widctlpar\ql\li0\ri0\lin0\rin0\tx720\tx1440\tx2160\tx2880\tx3600\tx4320\tx5040\tx5760\tx6480\tx7200\tx7920\tx8640\tx9360\tx10080\par}}}


\par\pard\ltrpar\itap0\nowidctlpar\ql\li0\ri0\lin0\rin0\tx720\tx1440\tx2160\tx2880\tx3600\tx4320\tx5040\tx5760\tx6480\tx7200\tx7920\tx8640\tx9360\tx10080\par }";
    }
}
