using System;
using System.Collections.Generic;
using System.Text;

namespace DropDownMenu.Models
{
    public class AdmissionScript
    {
        public int ID { get; set; }
        public int HumanID { get; set; }
        public Human Human { get; set; }

        public string AdmissionState { get; set; } // 一般，急，危急
        public string SourceFrom { get; set; } // 病人来源
        public string AdmissionWay { get; set; } // 入院方式：步行，轮椅，平车
        public string BeforeAdmission { get; set; } // 入院前病史特点
        public string PresentHistory { get; set; } // 现病史
        public string BodyExam { get; set; } // 体格检查
        public string AssistExam { get; set; } // 辅助检查
        public string DifferentialDiagnosis { get; set; } // 鉴别诊断
        public string InitialDiagnosis { get; set; } // 初步诊断
        public string MedicalOrders { get; set; } // 医嘱
    }
}
