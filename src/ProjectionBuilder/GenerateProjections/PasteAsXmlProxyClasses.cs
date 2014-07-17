using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateProjections
{

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class NamedColors
    {

        private NamedColorsNamedColor[] namedColorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NamedColor")]
        public NamedColorsNamedColor[] NamedColor
        {
            get
            {
                return this.namedColorField;
            }
            set
            {
                this.namedColorField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NamedColorsNamedColor
    {

        private string nameField;

        private string rGBField;

        private string[] emotionsField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string RGB
        {
            get
            {
                return this.rGBField;
            }
            set
            {
                this.rGBField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Emotion", IsNullable = false)]
        public string[] Emotions
        {
            get
            {
                return this.emotionsField;
            }
            set
            {
                this.emotionsField = value;
            }
        }
    }


}
