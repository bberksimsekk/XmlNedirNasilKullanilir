using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XMLNedirNasılKullanılır
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama

            //Xml extencible Marcub language açılımı olan genişletebilir işaretleme dili olarak taımlanabilir.
            //Html gibi etiketler kullanılarak oluşturulur. ancak xml'de etiketleri biz belirleriz.
            //Amacı veri depolamak veya farklı platformlar arasında veri transferi sağlamaktır.
            //RSS,Ajax,Web servisleri oluşturulabilir.
            //XML ile tanımlama yaparken herhangi bir standart yoktur. Ancak bazı kurallar uyulması gerekir.
            //En önemli kural XML dosyasının başında XML tanımlayıcısının oluşturulması gerekir.
            //<?xml version ="1.0" encoding="UTF-8"?>

            #endregion

            #region Xml Verilerini Okuyalım (READ)

            //XDocument dokuman = XDocument.Load("../../Kisiler.xml");
            //XElement rootelement = dokuman.Root;
            //foreach (XElement item in rootelement.Elements())
            //{
            //    int id = Convert.ToInt32(item.Attribute("id").Value);
            //    string isim = item.Element("adi").Value;
            //    string soyisim = item.Element("soyadi").Value;
            //    Console.WriteLine($"{id}) {isim} {soyisim}");
            //}

            #endregion

            #region Merkez Bankası Döviz Kurlarını Okuyalım

            //XDocument kurlar = XDocument.Load("https://www.tcmb.gov.tr/kurlar/today.xml");
            //XElement rootelement = kurlar.Root;
            //foreach (XElement kur in rootelement.Elements())
            //{
            //    string kod = kur.Attribute("Kod").Value;
            //    string isim = kur.Element("Isim").Value;
            //    int unit = int.Parse(kur.Element("Unit").Value);
            //    double forexselling = 0;
            //    if (!string.IsNullOrEmpty(kur.Element("ForexSelling").Value))
            //    {
            //        Convert.ToDouble(kur.Element("ForexSelling").Value.Replace('.', ','));
            //    }
            //    double satis = forexselling / unit;
            //    Console.WriteLine($"{kod} - {isim} = {satis} TL");
            //}

            #endregion

            #region Xml Verilerini Ekleme (ADD)

            //Console.WriteLine("ID = \t");
            //string id = Console.ReadLine();

            //Console.WriteLine("Isim = \t");
            //string isim = Console.ReadLine();

            //Console.WriteLine("Soyisim = \t");
            //string soyisim = Console.ReadLine();

            //string path = "../../Kisiler.xml";
            //XDocument dokuman = XDocument.Load(path);
            //XElement rootElement = dokuman.Root;

            //XElement yenieleman = new XElement("kisi");

            ////string guid = Guid.NewGuid().ToString();
            //XAttribute idAttribute = new XAttribute("id", id);
            //XElement isimElement = new XElement("adi", isim);
            //XElement soyisimElement = new XElement("soyadi", soyisim);

            //yenieleman.Add(idAttribute, isimElement, soyisimElement);
            //rootElement.Add(yenieleman);
            //dokuman.Save(path);

            #endregion

            #region Xml Verilerini Güncelleme (UPDATE)

            //string path = "../../Kisiler.xml";
            //XDocument dokuman = XDocument.Load(path);
            //XElement rootElement = dokuman.Root;

            //foreach (XElement item in rootElement.Elements())
            //{
            //    Console.WriteLine($"{item.Attribute("id").Value}) {item.Element("adi").Value} {item.Element("soyadi").Value}");
            //}
            //Console.WriteLine("Güncellemek İstediğiniz Kişinin ID Numarasını Giriniz Cnm Bnm");
            //string id = Console.ReadLine();

            //Console.WriteLine("Isim = ");
            //string isim = Console.ReadLine();

            //Console.WriteLine("Soyisim = ");
            //string soyisim = Console.ReadLine();

            //foreach (XElement item in rootElement.Elements())
            //{
            //    if(item.Attribute("id").Value == id)
            //    {
            //        item.Element("adi").Value = isim;
            //        item.Element("soyadi").Value = soyisim;
            //        break;
            //    }
            //}
            //dokuman.Save(path);
            //Console.WriteLine("Kişi Bilgileri Güncellenmiştir Cnm Bnm");

            #endregion

            #region Xml Verilerini Silme (DELETE)

            //string path = "../../Kisiler.xml";
            //XDocument dokuman = XDocument.Load(path);
            //XElement rootElement = dokuman.Root;

            //foreach (XElement item in rootElement.Elements())
            //{
            //    if (item.Attribute("id").Value == "2")
            //    {
            //        item.Remove();
            //    }
            //}
            //dokuman.Save(path);

            #endregion

        }
    }
}
