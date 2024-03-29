﻿using System.ComponentModel;

namespace blazorHramBabynino.Models
{
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
        [Description("Стояние Марии Египетской")]
        Стояние_Марии_Египетской,
        [Description("Похвала Пресвятой Богородицы")]
        Похвала_Богородицы,

        [Description("12-ть Страстных Евангелий")]
        Страстные_Евангелия,
        [Description("Вечерня с выносом плащаницы Спасителя")]
        Вечерня_Плащаница_Спасителя,
        [Description("Освящение куличей и пасох")]
        Куличи_и_пасхи,
        [Description("Литургия, освящение куличей и пасох")]
        Литургия_куличи_и_пасхи,
        [Description("Полунощница")]
        Полунощница,
        [Description("Крестный ход, Пасхальная Заутреня, Пасхальные Часы, Литургия")]
        Пасхальная_Заутреня,
        [Description("Крестный ход, Пасхальная Утреня, Пасхальные Часы, Литургия")]
        Пасхальная_Утреня,
        [Description("Литургия, Крестный ход")]
        Литургия_Крестный_ход,
        [Description("Литургия, молебен, панихида")]
        Литургия_молебен_панихида,
    }
}
