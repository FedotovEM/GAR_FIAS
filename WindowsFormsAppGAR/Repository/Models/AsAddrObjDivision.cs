using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WindowsFormsAppGAR.Repository.Models
{
    [Table("AS_ADDR_OBJ_DIVISION")]
    public partial class AsAddrObjDivision
    {
        [Key]
        [Column("ID")]
        public long Id { get; set; }
        [Column("PARENTID")]
        public long Parentid { get; set; }
        [Column("CHILDID")]
        public long Childid { get; set; }
        [Column("CHANGEID")]
        public long Changeid { get; set; }

        public static AsAddrObjDivision GetAttributeValue(XmlReader item)
        {
            AsAddrObjDivision asAddrObjDivision = new AsAddrObjDivision();

            item.MoveToAttribute("ID");
            asAddrObjDivision.Id = long.Parse(item.Value);
            item.MoveToAttribute("PARENTID");
            asAddrObjDivision.Parentid = long.Parse(item.Value);
            item.MoveToAttribute("CHILDID");
            asAddrObjDivision.Childid = long.Parse(item.Value);
            item.MoveToAttribute("CHANGEID");
            asAddrObjDivision.Changeid = long.Parse(item.Value);   

            return asAddrObjDivision;
        }
    }
}
