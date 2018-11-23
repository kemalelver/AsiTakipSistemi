using AşıTakipSistemi.Model.Context;
using AşıTakipSistemi.Model.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace AşıTakipSistemi.XML_işleri
{
    class DosyaYardımcısı
    {
        private static AşıDBContext AşıVeriTabanı= new AşıDBContext();
        private static string MainDirectoryPath = System.AppDomain.CurrentDomain.BaseDirectory;
        private static string ÇalışanPath = Path.Combine(MainDirectoryPath, "Çalışanlar.xml");
        private static string AşıPath = Path.Combine(MainDirectoryPath, "Aşılar.xml");
        private static string HastaPath = Path.Combine(MainDirectoryPath, "Hastalar.xml");

        public static void DosyaYarat()
        {

           
            if (!File.Exists(ÇalışanPath))
            {
                var file = File.Create(ÇalışanPath);
                file.Close();
            }

            if (!File.Exists(AşıPath))
            {
                var file = File.Create(AşıPath);
                file.Close();
            }

            if (!File.Exists(HastaPath))
            {
                var file = File.Create(HastaPath);
                file.Close();
            }
        }


        public static void ÇalışanDegerleriniDoldur()
        {
            CalisanlarSchema calisanlar = new CalisanlarSchema();          
            var çalışanBilgisi = (from Çalışanlar in AşıVeriTabanı.Çalışanlar
                                  
                                  select new { Çalışanlar.sicil_No, Çalışanlar.ad, Çalışanlar.soyad ,Çalışanlar.görev_Tipi, Çalışanlar.şifre}).ToList();

            List<CalisanlarSchemaCalisan> calisanList = new List<CalisanlarSchemaCalisan>();
           
                foreach (var o in çalışanBilgisi)
            {
                calisanList.Add(new CalisanlarSchemaCalisan() { Sicil_No = o.sicil_No.ToString(), ad = o.ad, soyad = o.soyad, gorev_Tipi = o.görev_Tipi.ToString(), sifre = o.şifre });
            }
            

            calisanlar.Calisan = calisanList.ToArray();
     
            XmlSerializer xs = new XmlSerializer(typeof(CalisanlarSchema));
            string xml = "";
 
            using (StringWriter sw = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sw))
                {
                    xs.Serialize(writer, calisanlar);
                    xml = sw.ToString();
                }
            }

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xml);
            xmlDoc.Save(ÇalışanPath);
        }

        public static void AşıDegerleriniDoldur()
        {
            AsilarSchema asilar = new AsilarSchema();
            var AşıBilgisi = (from a in AşıVeriTabanı.Aşılar

                                  select new { a.ID,a.aşı_Adı,a.doz1,a.doz2,a.doz3,a.doz4 }).ToList();

            List<AsilarSchemaAsi> asiList = new List<AsilarSchemaAsi>();

            foreach (var o in AşıBilgisi)
            {
                asiList.Add(new AsilarSchemaAsi() { asi_Adi = o.aşı_Adı, ID = o.ID.ToString(), doz1 = o.doz1.ToString(), doz2 = o.doz2.ToString(),
                                                                                            doz3=o.doz3.ToString(),doz4=o.doz4.ToString()});
            }


            asilar.Asi = asiList.ToArray();

            XmlSerializer xs = new XmlSerializer(typeof(AsilarSchema));
            string xml = "";

            using (StringWriter sw = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sw))
                {
                    xs.Serialize(writer, asilar);
                    xml = sw.ToString();
                }
            }

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xml);
            xmlDoc.Save(AşıPath);
        }

        public static void HastaDegerleriniDoldur()
        {
            HastalarSchema hastalar = new HastalarSchema();
            var HastaBilgisi = (from a in AşıVeriTabanı.Hastalar

                              select new { a.TC_Kimlik_No,a.ad,a.soyad,a.doğum_Tarihi,a.olduğu_Aşılar }).ToList();

            List<HastalarSchemaHasta> hastaList = new List<HastalarSchemaHasta>();

            foreach (var o in HastaBilgisi)
            {
                hastaList.Add(new HastalarSchemaHasta()
                {
                    TC = o.TC_Kimlik_No,
                    ad= o.ad,
                    soyad=o.soyad,
                    dogum_Tarihi=o.doğum_Tarihi,
                    oldugu_Asilar=o.olduğu_Aşılar

                });
            }


            hastalar.Hasta = hastaList.ToArray();

            XmlSerializer xs = new XmlSerializer(typeof(HastalarSchema));
            string xml = "";

            using (StringWriter sw = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sw))
                {
                    xs.Serialize(writer, hastalar);
                    xml = sw.ToString();
                }
            }

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xml);
            xmlDoc.Save(HastaPath);
        }

        public static void Database_doldur()
        {
           
            if (File.Exists(ÇalışanPath))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(ÇalışanPath);
                // Xml içerisindeki ilk node <xml> tanıtıcı node'u olduğundan ikinci node olan 1. index'e erişiyoruz.
                XmlNode menuNode = xmlDoc.ChildNodes[1];
                foreach (XmlNode item in menuNode)
                {                 
                    AşıVeriTabanı.Çalışanlar.Add(new Çalışanlar
                    {
                        sicil_No = Convert.ToInt32(item["Sicil_No"].InnerText.Trim()),
                        ad = item["ad"].InnerText.Trim(),
                        soyad = item["soyad"].InnerText.Trim(),
                        görev_Tipi = Int32.Parse(item["gorev_Tipi"].InnerText.Trim()),
                        şifre = item["sifre"].InnerText.Trim()
                    });
                    
                }
                AşıVeriTabanı.SaveChanges();
            }
            if (File.Exists(HastaPath))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(HastaPath);
                // Xml içerisindeki ilk node <xml> tanıtıcı node'u olduğundan ikinci node olan 1. index'e erişiyoruz.
                XmlNode menuNode = xmlDoc.ChildNodes[1];
                foreach (XmlNode item in menuNode)
                {
                    AşıVeriTabanı.Hastalar.Add(new Hastalar
                    {
                        TC_Kimlik_No = Convert.ToDouble(item["TC"].InnerText.Trim()),
                        ad = item["ad"].InnerText.Trim(),
                        soyad = item["soyad"].InnerText.Trim(),
                        doğum_Tarihi = Convert.ToDateTime(item["dogum_Tarihi"].InnerText.Trim()),
                        olduğu_Aşılar = item["oldugu_Asilar"].InnerText.Trim()
                    });

                }
                AşıVeriTabanı.SaveChanges();
            }
            if (File.Exists(AşıPath))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(AşıPath);
                // Xml içerisindeki ilk node <xml> tanıtıcı node'u olduğundan ikinci node olan 1. index'e erişiyoruz.
                XmlNode menuNode = xmlDoc.ChildNodes[1];
                foreach (XmlNode item in menuNode)
                {
                    AşıVeriTabanı.Aşılar.Add(new Aşılar
                    {
                        ID = Convert.ToInt32(item["ID"].InnerText.Trim()),
                        aşı_Adı = item["asi_Adi"].InnerText.Trim(),
                        doz1 = Convert.ToInt32(item["doz1"].InnerText.Trim()),
                        doz2 = Convert.ToInt32(item["doz2"].InnerText.Trim()),
                        doz3 = Convert.ToInt32(item["doz3"].InnerText.Trim()),
                        doz4 = Convert.ToInt32(item["doz4"].InnerText.Trim())
                    });

                }
                AşıVeriTabanı.SaveChanges();
            }

        }
    }
}
