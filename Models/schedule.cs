using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using System.Linq;
using System.Threading.Tasks;

namespace blazorHramBabynino.Models
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
        [Description("Парастас")]
        Парастас,

    }

    public enum тип_праздника
    {
        [Description("")]
        пусто = 0,
        [Description("жирный")]
        жирный = 1,
        [Description("курсив")]
        курсив = 2,
        [Description("жирный заглавный")]
        жирный_заглавный = 3,

        [Description("синий")]
        primary = 4,
        [Description("зелёный")]
        success = 5,
        [Description("красный")]
        danger = 6,
        [Description("жёлтый")]
        warning = 7,
        [Description("голубой")]
        info = 8,
        [Description("светлый")]
        light = 9,
        [Description("серый")]
        secondary = 10,

        [Description("синий курсив")]
        primary_cursive = 11,
        [Description("зелёный курсив")]
        success_cursive = 12,
        [Description("красный курсив")]
        danger_cursive = 13,
        [Description("жёлтый курсив")]
        warning_cursive = 14,
        [Description("голубой курсив")]
        info_cursive = 15,
        [Description("светлый курсив")]
        light_cursive = 16,
        [Description("серый курсив")]
        secondary_cursive = 17,

        [Description("синий жирный")]
        primary_bold = 18,
        [Description("зелёный жирный")]
        success_bold = 19,
        [Description("красный жирный")]
        danger_bold = 20,
        [Description("жёлтый жирный")]
        warning_bold = 21,
        [Description("голубой жирный")]
        info_bold = 22,
        [Description("светлый жирный")]
        light_bold = 23,
        [Description("серый жирный")]
        secondary_bold = 24,

        [Description("синий жирный заглавный")]
        primary_bold_up = 25,
        [Description("зелёный жирный заглавный")]
        success_bold_up = 26,
        [Description("красный жирный заглавный")]
        danger_bold_up = 27,
        [Description("жёлтый жирный заглавный")]
        warning_bold_up = 28,
        [Description("голубой жирный заглавный")]
        info_bold_up = 29,
        [Description("светлый жирный заглавный")]
        light_bold_up = 30,
        [Description("серый жирный заглавный")]
        secondary_bold_up = 31
    }
}
