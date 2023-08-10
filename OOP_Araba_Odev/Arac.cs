using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Araba_Odev
{
    public class Arac
    {
		private int _modelyili;
        private int _motorgucu;
        

        public bool Garanti{get;set;}

        public string AracTuru { get; set; }
        public string AracMarkasi { get; set; }
        public string AracModeli { get; set; }
        public string AracSanzimani { get; set; }
        public string YakitTipi { get; set; }
        public string KasaTipi { get; set; }
  
        public int ModelYili
		{
			get { return _modelyili; }
			set 
			{
                if (value>2005)
                {
	                _modelyili = value;
                }
                else
                {
                    throw new Exception("2005 yılından daha eski araçlar işlem görmemektedir.");
                }
            }
		}

		public int MotorGucu
		{
			get { return _motorgucu; }
			set 
			{
                if (value<1000)
                {
					throw new Exception("Motor gücü en az 1000 olabilir.");
                }
                else
                {
                    _motorgucu = value;

                }
            }
		}

        public IEnumerable<Control> Controls { get; private set; }

        public override string ToString()
        {
            return $"Arabanın markası: {AracMarkasi}, Modeli: {AracModeli}, Araç Türü: {AracTuru}, Araç Şanzımanı: {AracSanzimani}, Araç yakıt tipi: {YakitTipi}, Araç Kasa tipi: {KasaTipi}";
        }
        

    }
}
    
