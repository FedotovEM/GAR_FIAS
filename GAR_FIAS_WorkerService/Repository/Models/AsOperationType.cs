using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;
using Microsoft.EntityFrameworkCore;

namespace GAR_FIAS_WorkerService.Repository.Models
{
    [Table("AS_OPERATION_TYPES")]
    public partial class AsOperationType
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("NAME")]
        [StringLength(100)]
        [Unicode(false)]
        public string Name { get; set; }
        [Column("SHORTNAME")]
        [StringLength(100)]
        [Unicode(false)]
        public string Shortname { get; set; }
        [StringLength(250)]
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

        public static AsOperationType GetAttributeValue(XmlReader item)
        {
            AsOperationType asOperationType = new AsOperationType();

            item.MoveToAttribute("ID");
            asOperationType.Id = int.Parse(item.Value);
            item.MoveToAttribute("NAME");
            asOperationType.Name = item.Value;

            if (item.MoveToAttribute("SHORTNAME"))
                asOperationType.Shortname = item.Value;
            else
                asOperationType.Shortname = null;

            if (item.MoveToAttribute("DESC"))
                asOperationType.Desk = item.Value;
            else
                asOperationType.Desk = null;

            item.MoveToAttribute("UPDATEDATE");
            asOperationType.Updatedate = DateTime.Parse(item.Value);
            item.MoveToAttribute("STARTDATE");
            asOperationType.Startdate = DateTime.Parse(item.Value);
            item.MoveToAttribute("ENDDATE");
            asOperationType.Enddate = DateTime.Parse(item.Value);

            item.MoveToAttribute("ISACTIVE");
            string IsactiveValue = item.Value;
            if (IsactiveValue == "1" || IsactiveValue == "true")
                asOperationType.Isactive = true;
            else
                asOperationType.Isactive = false;

            return asOperationType;
        }
    }
}
