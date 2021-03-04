using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using System.Linq;
using System.Threading.Tasks;

namespace razorHramBabynino.Models
{  
    [Table(name: "schedule")]
    public class schedule_string
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Дата и время")]
        public DateTime date_and_time { get; set; }
        /// <summary>
        /// Праздник
        /// </summary>
        [Display(Name = "Праздник")]
        public string description { get; set; }
        /// <summary>
        /// Служба
        /// </summary>
        [Display(Name = "Служба")]
        public тип_службы prayer { get; set; }
        [Display(Name ="Цвет или формат текста")]
        public тип_праздника тип_праздника { get; set; }

        /// <summary>
        /// Метод, который позволяет получить значение атрибута "description" для этого enum
        /// </summary>
        public static string GetDescription(Enum enumElement)
        {
            Type type = enumElement.GetType();

            MemberInfo[] memInfo = type.GetMember(enumElement.ToString());
            if (memInfo != null && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attrs != null && attrs.Length > 0)
                    return ((DescriptionAttribute)attrs[0]).Description;
            }

            return enumElement.ToString();
        }
    }

    public enum тип_службы
    {
        [Description("")]
        пусто,
        [Description("Литургия")]
        Литургия,
        [Description("Всенощное бдение")]
        Всенощное_бдение,
        [Description("Молебен")]
        Молебен,
        [Description("Акафист")]
        Акафист,
        [Description("Панихида")]
        Панихида,
        [Description("Литургия, молебен")]
        Литургия_и_молебен,
        [Description("Литургия, панихида")]
        Литургия_и_панихида,
        [Description("Молебен с акафистом")]
        Молебен_с_акафистом,
        [Description("Молебен с освящением воды")]
        Молебен_с_освящением,
        [Description("Великая вечерня, Литургия Василия Великого")]
        Великая_вечерня_и_Литургия_Василия_Великого,
        [Description("Великое повечерие, Утреня")]
        Великое_повечерие_и_утреня,
        [Description("Литургия Иоанна Златоустого")]
        Литургия_Иоанна_Златоустого,
        [Description("Литургия Василия Великого")]
        Литургия_Василия_Великого,
        [Description("Царские часы")]
        Царские_часы,

        [Description("Утреня, Часы, Изобразительны, Вечерня")]
        Великий_пост_утро1,
        [Description("Утреня, Часы, Вечерня, Литургия")]
        Великий_пост_утро2,
        [Description("Утреня, Часы, Вечерня, Литургия Преждеосвященных Даров")]
        Великий_пост_утро3,
        [Description("Утреня, Часы, Вечерня, Литургия Василия Великого")]
        Великий_пост_утро4,
        [Description("Утреня, Часы, Вечерня, Литургия Иоанна Златоустого")]
        Великий_пост_утро5,
        [Description("Утреня, 1 Час")]
        Великий_пост_утро6,
        [Description("Часы, Вечерня, Литургия")]
        Великий_пост_утро7,
        [Description("Часы, Вечерня, Литургия Преждеосвященных Даров")]
        Великий_пост_утро8,
        [Description("Часы, Вечерня, Литургия Василия Великого")]
        Великий_пост_утро9,
        [Description("Часы, Вечерня, Литургия Иоанна Златоустого")]
        Великий_пост_утро10,


        [Description("Канон Андрея Критского")]
        Канон_Андрея_Критского,
        [Description("Повечение, Канон Андрея Критского")]
        Повечерие_Канон_Андрея_Критского,
        [Description("Соборование")]
        Соборование,

    }

    public enum тип_праздника
    {
        [Description("")]
        пусто =0,
        [Description("жирный")]
        жирный =1,
        [Description("курсив")]
        курсив =2,
        [Description("жирный заглавный")]
        жирный_заглавный =3,
        [Description("primary")]
        primary =4
    }
}
