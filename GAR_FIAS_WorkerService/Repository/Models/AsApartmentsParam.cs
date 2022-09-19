using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace GAR_FIAS_WorkerService.Repository.Models
{
    [Table("AS_APARTMENTS_PARAMS")]
    public partial class AsApartmentsParam
    {
        [Key]
        [Column("ID")]
        public long Id { get; set; }
        [Column("OBJECTID")]
        public long Objectid { get; set; }
        [Column("CHANGEID")]
        public long Changeid { get; set; }
        [Column("CHANGEIDEND")]
        public long Changeidend { get; set; }
        [Column("TYPEID")]
        public int Typeid { get; set; }
        [Required]
        [Column("VALUE")]
        [StringLength(36)]
        public string Value { get; set; }
        [Column("UPDATEDATE", TypeName = "date")]
        public DateTime Updatedate { get; set; }
        [Column("STARTDATE", TypeName = "date")]
        public DateTime Startdate { get; set; }
        [Column("ENDDATE", TypeName = "date")]
        public DateTime Enddate { get; set; }
        public static AsApartmentsParam GetAttributeValue(XmlReader item)
        {
            AsApartmentsParam asApartmentsParams = new AsApartmentsParam();

            item.MoveToAttribute("ID");
            asApartmentsParams.Id = long.Parse(item.Value);
            item.MoveToAttribute("OBJECTID");
            asApartmentsParams.Objectid = long.Parse(item.Value);
            item.MoveToAttribute("CHANGEID");
            asApartmentsParams.Changeid = long.Parse(item.Value);
            item.MoveToAttribute("CHANGEIDEND");
            asApartmentsParams.Changeidend = long.Parse(item.Value);
            item.MoveToAttribute("TYPEID");
            asApartmentsParams.Typeid = int.Parse(item.Value);
            item.MoveToAttribute("VALUE");
            asApartmentsParams.Value = item.Value;
            item.MoveToAttribute("UPDATEDATE");
            asApartmentsParams.Updatedate = DateTime.Parse(item.Value);
            item.MoveToAttribute("STARTDATE");
            asApartmentsParams.Startdate = DateTime.Parse(item.Value);
            item.MoveToAttribute("ENDDATE");
            asApartmentsParams.Enddate = DateTime.Parse(item.Value);

            return asApartmentsParams;
        }
    }
}
