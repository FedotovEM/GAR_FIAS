using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;
using Microsoft.EntityFrameworkCore;

namespace GAR_FIAS_WorkerService.Repository.Models
{
    [Table("AS_PARAM_TYPES")]
    public partial class AsParamType
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("NAME")]
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; }
        [Required]
        [Column("CODE")]
        [StringLength(50)]
        [Unicode(false)]
        public string Code { get; set; }
        [StringLength(120)]
        [Unicode(false)]
        public string Desk { get; set; }
        [Column("UPDATEDATE", TypeName = "date")]
        public DateTime Updatedate { get; set; }
        [Column("STARTDATE", TypeName = "date")]
        public DateTime Startdate { get; set; }
        [Column("ENDDATE", TypeName = "date")]
        public DateTime Enddate { get; set; }
        [Column("ISACTIVE")]
        public bool Isactive { get; set; }

        public static AsParamType GetAttributeValue(XmlReader item)
        {
            AsParamType asParamType = new AsParamType();

            item.MoveToAttribute("ID");
            asParamType.Id = int.Parse(item.Value);
            item.MoveToAttribute("NAME");
            asParamType.Name = item.Value;
            item.MoveToAttribute("CODE");
            asParamType.Code = item.Value;

            if (item.MoveToAttribute("DESC"))
                asParamType.Desk = item.Value;
            else
                asParamType.Desk = null;

            item.MoveToAttribute("UPDATEDATE");
            asParamType.Updatedate = DateTime.Parse(item.Value);
            item.MoveToAttribute("STARTDATE");
            asParamType.Startdate = DateTime.Parse(item.Value);
            item.MoveToAttribute("ENDDATE");
            asParamType.Enddate = DateTime.Parse(item.Value);

            item.MoveToAttribute("ISACTIVE");
            string IsactiveValue = item.Value;
            if (IsactiveValue == "1" || IsactiveValue == "true")
                asParamType.Isactive = true;
            else
                asParamType.Isactive = false;

            return asParamType;
        }
    }
}
