//-----------------------------------------------------------------------------
// Copyright 2000-2021 CEA (www.cea.fr) IFPEN (www.ifpenergiesnouvelles.com)
// See the top-level COPYRIGHT file for details.
// SPDX-License-Identifier: Apache-2.0
//-----------------------------------------------------------------------------
using System.Text;

namespace Arcane.Axl
{
  public class CommonEntities
  {
    internal const string ENTITIES = "";

    static void _Add(StringBuilder sb,string name,string value)
    {
      sb.AppendFormat("<!ENTITY {0} '&#x{1};'>\n",name,value);
    }

    static public string Build()
    {
      StringBuilder sb = new StringBuilder();
      _Add(sb,"alpha","03B1");
      _Add(sb,"beta","03B2");
      _Add(sb,"gamma","03B3");
      _Add(sb,"Gamma","0393");
      _Add(sb,"gammad","03DC");
      _Add(sb,"delta","03B4");
      _Add(sb,"Delta","0394");
      _Add(sb,"epsi","220A");
      _Add(sb,"epsiv","03B5");
      _Add(sb,"epsis","220A");
      _Add(sb,"zeta","03B6");
      _Add(sb,"eta","03B7");
      _Add(sb,"thetas","03B8");
      _Add(sb,"Theta","0398");
      _Add(sb,"thetav","03D1");
      _Add(sb,"iota","03B9");
      _Add(sb,"kappa","03BA");
      _Add(sb,"kappav","03F0");
      _Add(sb,"lambda","03BB");
      _Add(sb,"Lambda","039B");
      _Add(sb,"mu","03BC");
      _Add(sb,"nu","03BD");
      _Add(sb,"xi","03BE");
      _Add(sb,"Xi","039E");
      _Add(sb,"pi","03C0");
      _Add(sb,"piv","03D6");
      _Add(sb,"Pi","03A0");
      _Add(sb,"rho","03C1");
      _Add(sb,"rhov","03F1");
      _Add(sb,"sigma","03C3");
      _Add(sb,"Sigma","03A3");
      _Add(sb,"sigmav","03C2");
      _Add(sb,"tau","03C4");
      _Add(sb,"upsi","03C5");
      _Add(sb,"Upsi","03D2");
      _Add(sb,"phis","03C6");
      _Add(sb,"Phi","03A6");
      _Add(sb,"phiv","03D5");
      _Add(sb,"chi","03C7");
      _Add(sb,"psi","03C8");
      _Add(sb,"Psi","03A8");
      _Add(sb,"omega","03C9");
      _Add(sb,"Omega","03A9");
      _Add(sb,"aacute","00E1");
      _Add(sb,"Aacute","00C1");
      _Add(sb,"acirc","00E2");
      _Add(sb,"Acirc","00C2");
      _Add(sb,"agrave","00E0");
      _Add(sb,"Agrave","00C0");
      _Add(sb,"aring","00E5");
      _Add(sb,"Aring","00C5");
      _Add(sb,"atilde","00E3");
      _Add(sb,"Atilde","00C3");
      _Add(sb,"auml","00E4");
      _Add(sb,"Auml","00C4");
      _Add(sb,"aelig","00E6");
      _Add(sb,"AElig","00C6");
      _Add(sb,"ccedil","00E7");
      _Add(sb,"Ccedil","00C7");
      _Add(sb,"eth","00F0");
      _Add(sb,"ETH","00D0");
      _Add(sb,"eacute","00E9");
      _Add(sb,"Eacute","00C9");
      _Add(sb,"ecirc","00EA");
      _Add(sb,"Ecirc","00CA");
      _Add(sb,"egrave","00E8");
      _Add(sb,"Egrave","00C8");
      _Add(sb,"euml","00EB");
      _Add(sb,"Euml","00CB");
      _Add(sb,"iacute","00ED");
      _Add(sb,"Iacute","00CD");
      _Add(sb,"icirc","00EE");
      _Add(sb,"Icirc","00CE");
      _Add(sb,"igrave","00EC");
      _Add(sb,"Igrave","00CC");
      _Add(sb,"iuml","00EF");
      _Add(sb,"Iuml","00CF");
      _Add(sb,"ntilde","00F1");
      _Add(sb,"Ntilde","00D1");
      _Add(sb,"oacute","00F3");
      _Add(sb,"Oacute","00D3");
      _Add(sb,"ocirc","00F4");
      _Add(sb,"Ocirc","00D4");
      _Add(sb,"ograve","00F2");
      _Add(sb,"Ograve","00D2");
      _Add(sb,"oslash","00F8");
      _Add(sb,"Oslash","00D8");
      _Add(sb,"otilde","00F5");
      _Add(sb,"Otilde","00D5");
      _Add(sb,"ouml","00F6");
      _Add(sb,"Ouml","00D6");
      _Add(sb,"szlig","00DF");
      _Add(sb,"thorn","00FE");
      _Add(sb,"THORN","00DE");
      _Add(sb,"uacute","00FA");
      _Add(sb,"Uacute","00DA");
      _Add(sb,"ucirc","00FB");
      _Add(sb,"Ucirc","00DB");
      _Add(sb,"ugrave","00F9");
      _Add(sb,"Ugrave","00D9");
      _Add(sb,"uuml","00FC");
      _Add(sb,"Uuml","00DC");
      _Add(sb,"yacute","00FD");
      _Add(sb,"Yacute","00DD");
      _Add(sb,"yuml","00FF");
      _Add(sb,"abreve","0103");
      _Add(sb,"Abreve","0102");
      _Add(sb,"amacr","0101");
      _Add(sb,"Amacr","0100");
      _Add(sb,"aogon","0105");
      _Add(sb,"Aogon","0104");
      _Add(sb,"cacute","0107");
      _Add(sb,"Cacute","0106");
      _Add(sb,"ccaron","010D");
      _Add(sb,"Ccaron","010C");
      _Add(sb,"ccirc","0109");
      _Add(sb,"Ccirc","0108");
      _Add(sb,"cdot","010B");
      _Add(sb,"Cdot","010A");
      _Add(sb,"dcaron","010F");
      _Add(sb,"Dcaron","010E");
      _Add(sb,"dstrok","0111");
      _Add(sb,"Dstrok","0110");
      _Add(sb,"ecaron","011B");
      _Add(sb,"Ecaron","011A");
      _Add(sb,"edot","0117");
      _Add(sb,"Edot","0116");
      _Add(sb,"emacr","0113");
      _Add(sb,"Emacr","0112");
      _Add(sb,"eogon","0119");
      _Add(sb,"Eogon","0118");
      _Add(sb,"gacute","01F5");
      _Add(sb,"gbreve","011F");
      _Add(sb,"Gbreve","011E");
      _Add(sb,"Gcedil","0122");
      _Add(sb,"gcirc","011D");
      _Add(sb,"Gcirc","011C");
      _Add(sb,"gdot","0121");
      _Add(sb,"Gdot","0120");
      _Add(sb,"hcirc","0125");
      _Add(sb,"Hcirc","0124");
      _Add(sb,"hstrok","0127");
      _Add(sb,"Hstrok","0126");
      _Add(sb,"Idot","0130");
      _Add(sb,"Imacr","012A");
      _Add(sb,"imacr","012B");
      _Add(sb,"ijlig","0133");
      _Add(sb,"IJlig","0132");
      _Add(sb,"inodot","0131");
      _Add(sb,"iogon","012F");
      _Add(sb,"Iogon","012E");
      _Add(sb,"itilde","0129");
      _Add(sb,"Itilde","0128");
      _Add(sb,"jcirc","0135");
      _Add(sb,"Jcirc","0134");
      _Add(sb,"kcedil","0137");
      _Add(sb,"Kcedil","0136");
      _Add(sb,"kgreen","0138");
      _Add(sb,"lacute","013A");
      _Add(sb,"Lacute","0139");
      _Add(sb,"lcaron","013E");
      _Add(sb,"Lcaron","013D");
      _Add(sb,"lcedil","013C");
      _Add(sb,"Lcedil","013B");
      _Add(sb,"lmidot","0140");
      _Add(sb,"Lmidot","013F");
      _Add(sb,"lstrok","0142");
      _Add(sb,"Lstrok","0141");
      _Add(sb,"nacute","0144");
      _Add(sb,"Nacute","0143");
      _Add(sb,"eng","014B");
      _Add(sb,"ENG","014A");
      _Add(sb,"napos","0149");
      _Add(sb,"ncaron","0148");
      _Add(sb,"Ncaron","0147");
      _Add(sb,"ncedil","0146");
      _Add(sb,"Ncedil","0145");
      _Add(sb,"odblac","0151");
      _Add(sb,"Odblac","0150");
      _Add(sb,"Omacr ","014C");
      _Add(sb,"omacr","014D");
      _Add(sb,"oelig ","0153");
      _Add(sb,"OElig","0152");
      _Add(sb,"racute","0155");
      _Add(sb,"Racute","0154");
      _Add(sb,"rcaron","0159");
      _Add(sb,"Rcaron","0158");
      _Add(sb,"rcedil","0157");
      _Add(sb,"Rcedil","0156");
      _Add(sb,"sacute","015B");
      _Add(sb,"Sacute","015A");
      _Add(sb,"scaron","0161");
      _Add(sb,"Scaron","0160");
      _Add(sb,"scedil","015F");
      _Add(sb,"Scedil","015E");
      _Add(sb,"scirc","015D");
      _Add(sb,"Scirc ","015C");
      _Add(sb,"tcaron","0165");
      _Add(sb,"Tcaron","0164");
      _Add(sb,"tcedil","0163");
      _Add(sb,"Tcedil","0162");
      _Add(sb,"tstrok","0167");
      _Add(sb,"Tstrok","0166");
      _Add(sb,"ubreve","016D");
      _Add(sb,"Ubreve","016C");
      _Add(sb,"udblac","0171");
      _Add(sb,"Udblac","0170");
      _Add(sb,"umacr","016B");
      _Add(sb,"Umacr","016A");
      _Add(sb,"uogon","0173");
      _Add(sb,"Uogon","0172");
      _Add(sb,"uring ","016F");
      _Add(sb,"Uring","016E");
      _Add(sb,"utilde","0169");
      _Add(sb,"Utilde","0168");
      _Add(sb,"wcirc","0175");
      _Add(sb,"Wcirc","0174");
      _Add(sb,"ycirc","0177");
      _Add(sb,"Ycirc","0176");
      _Add(sb,"Yuml","0178");
      _Add(sb,"zacute","017A");
      _Add(sb,"Zacute","0179");
      _Add(sb,"zcaron","017E");
      _Add(sb,"Zcaron","017D");
      _Add(sb,"zdot","017C");
      _Add(sb,"Zdot","017B");

      _Add(sb,"odash","229D");
      _Add(sb,"nvdash","22AC");
      _Add(sb,"nvDash","22AD");
      _Add(sb,"nVDash","22AF");
      _Add(sb,"nVdash","22AE");
      _Add(sb,"dashv","22A3");
      _Add(sb,"vdash","22A2");
      _Add(sb,"Vdash","22A9");
      _Add(sb,"vDash","22A8");
      _Add(sb,"Vvdash","22AA");
      _Add(sb,"mdash","2014");
      _Add(sb,"ndash","2013");
      _Add(sb,"dash","2010");
      _Add(sb,"nbsp","00A0");
      _Add(sb,"laquo","00AB");

      return sb.ToString();
    }
  }
}