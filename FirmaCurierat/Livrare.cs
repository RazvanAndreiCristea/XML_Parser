using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirmaCurierat
{
    public class Destinatar
    {
        public string Nume { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }

        public Destinatar(XElement xmlElement)
        {
            Nume = (string)xmlElement.Element("nume");
            Telefon = (string)xmlElement.Element("telefon");
            Email = (string)xmlElement.Element("email");
            Adresa = (string)xmlElement.Element("adresa");
        }

        public Destinatar(dynamic jsonDocument)
        {
            Nume = jsonDocument.nume;
            Telefon = jsonDocument.telefon;
            Email = jsonDocument.email;
            Adresa = jsonDocument.adresa;
        }
    }

    public class Colet
    {
        public decimal Lungime { get; set; }
        public decimal Latime { get; set; }
        public decimal Inaltime { get; set; }
        public string UnitateMasuraDimensiuni { get; set; }
        public decimal Greutate { get; set; }
        public string UnitateMasuraGreutate { get; set; }
        public decimal Valoare { get; set; }
        public string UnitateMasuraValoare { get; set; }
        public string Destinatie { get; set; }
        public string TipAmbalaj { get; set; }
        public string Continut { get; set; }

        public Colet(XElement element)
        {
            Lungime = (decimal)element.Element("dimensiuni").Attribute("lungime");
            Latime = (decimal)element.Element("dimensiuni").Attribute("latime");
            Inaltime = (decimal)element.Element("dimensiuni").Attribute("inaltime");
            UnitateMasuraDimensiuni = (string)element.Element("dimensiuni").Attribute("unitate_masura");

            UnitateMasuraGreutate = (string)element.Element("greutate").Attribute("unitate_masura");
            Greutate = (decimal)element.Element("greutate");

            UnitateMasuraValoare = (string)element.Element("valoare").Attribute("unitate_masura");
            Valoare = (decimal)element.Element("valoare");

            Destinatie = (string)element.Element("destinatie");
            TipAmbalaj = (string)element.Element("ambalaj").Attribute("tip");
            Continut = (string)element.Element("continut");
        }

        public Colet(dynamic jsonDoc)
        {
            Lungime = (decimal)jsonDoc.dimensiuni.lungime;
            Latime = (decimal)jsonDoc.dimensiuni.latime;
            Inaltime = (decimal)jsonDoc.dimensiuni.inaltime;
            UnitateMasuraDimensiuni = jsonDoc.dimensiuni.unitate_masura;

            UnitateMasuraGreutate = jsonDoc.greutate.unitate_masura;
            Greutate = (decimal)jsonDoc.greutate.valoare;

            UnitateMasuraValoare = jsonDoc.valoare.unitate_masura;
            Valoare = (decimal)jsonDoc.valoare.valoare;

            Destinatie = jsonDoc.destinatie;
            TipAmbalaj = jsonDoc.ambalaj.tip;
            Continut = jsonDoc.continut;
        }
    }

    public class Livrare
    {
        public int Id { get; set; }
        public string TipLivrare { get; set; }
        public Destinatar Destinatar { get; set; }
        public string Expeditor { get; set; }
        public Colet Colet { get; set; }
        public DateTime DataProgramata { get; set; }
        public string StareLivrare { get; set; }
        public string LocatieCurenta { get; set; }

        public Livrare(XElement xmlElement)
        {
            Id = (int)xmlElement.Attribute("id");
            TipLivrare = (string)xmlElement.Attribute("tip_livrare");

            Destinatar = new Destinatar(xmlElement.Element("destinatar"));
            Expeditor = (string)xmlElement.Element("expeditor");
            Colet = new Colet(xmlElement.Element("colet"));

            DataProgramata = DateTime.Parse((string)xmlElement.Element("data_programata"));
            StareLivrare = (string)xmlElement.Element("stare_livrare");
            LocatieCurenta = (string)xmlElement.Element("locatie_curenta");
        }

        public Livrare(dynamic jsonDocument)
        {
            Id = jsonDocument.id;
            TipLivrare = jsonDocument.tip_livrare;

            Destinatar = new Destinatar(jsonDocument.destinatar);
            Expeditor = jsonDocument.expeditor;
            Colet = new Colet(jsonDocument.colet);

            string dataProgramata = jsonDocument.data_programata;

            DataProgramata = DateTime.Parse(dataProgramata);
            StareLivrare = jsonDocument.stare_livrare;
            LocatieCurenta = jsonDocument.locatie_curenta;
        }
    }
}