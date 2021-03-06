﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SubscriptionPlan.XamarinUI.Models
{
    public class Plan
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public ChargeType ChargeType { get; set; }

        public string ChargeTypePresentation
        {
            get
            {
                switch (ChargeType)
                {
                    case ChargeType.Yearly:
                        return " / year";
                    case ChargeType.Monthly:
                    default:
                        return " / month";
                }
            }
        }

        public string TitleAndChargeTypePresentation => Title + " - " + ChargeType.ToString().ToLower();

        public decimal Price { get; set; }

        public string PricePresentation { get { return Price.ToString("C"); } }

        public static ObservableCollection<Plan> GetPlans()
        {
            return new ObservableCollection<Plan>
            {
                new Plan
                {
                    Title = "Base",
                    Description = @"Mussum Ipsum, cacilds vidis litro abertis. Delegadis gente finis, bibendum egestas augue arcu ut est. Pra lá , depois divoltis porris, paradis. Copo furadis é disculpa de bebadis, arcu quam euismod magna. Si num tem leite então bota uma pinga aí cumpadi!

Posuere libero varius. Nullam a nisl ut ante blandit hendrerit. Aenean sit amet nisi. Não sou faixa preta cumpadi, sou preto inteiris, inteiris. Detraxit consequat et quo num tendi nada. Leite de capivaris, leite de mula manquis sem cabeça.

Praesent vel viverra nisi. Mauris aliquet nunc non turpis scelerisque, eget. Suco de cevadiss, é um leite divinis, qui tem lupuliz, matis, aguis e fermentis. Per aumento de cachacis, eu reclamis. Suco de cevadiss deixa as pessoas mais interessantis.",
                    Price = 10
                },
                new Plan
                {
                    Title = "Medium",
                    Description = @"Mussum Ipsum, cacilds vidis litro abertis. Delegadis gente finis, bibendum egestas augue arcu ut est. Pra lá , depois divoltis porris, paradis. Copo furadis é disculpa de bebadis, arcu quam euismod magna. Si num tem leite então bota uma pinga aí cumpadi!

Posuere libero varius. Nullam a nisl ut ante blandit hendrerit. Aenean sit amet nisi. Não sou faixa preta cumpadi, sou preto inteiris, inteiris. Detraxit consequat et quo num tendi nada. Leite de capivaris, leite de mula manquis sem cabeça.

Praesent vel viverra nisi. Mauris aliquet nunc non turpis scelerisque, eget. Suco de cevadiss, é um leite divinis, qui tem lupuliz, matis, aguis e fermentis. Per aumento de cachacis, eu reclamis. Suco de cevadiss deixa as pessoas mais interessantis.",
                    Price = 30
                },
                new Plan
                {
                    Title = "Ultimate",
                    Description = @"Mussum Ipsum, cacilds vidis litro abertis. Delegadis gente finis, bibendum egestas augue arcu ut est. Pra lá , depois divoltis porris, paradis. Copo furadis é disculpa de bebadis, arcu quam euismod magna. Si num tem leite então bota uma pinga aí cumpadi!

Posuere libero varius. Nullam a nisl ut ante blandit hendrerit. Aenean sit amet nisi. Não sou faixa preta cumpadi, sou preto inteiris, inteiris. Detraxit consequat et quo num tendi nada. Leite de capivaris, leite de mula manquis sem cabeça.

Praesent vel viverra nisi. Mauris aliquet nunc non turpis scelerisque, eget. Suco de cevadiss, é um leite divinis, qui tem lupuliz, matis, aguis e fermentis. Per aumento de cachacis, eu reclamis. Suco de cevadiss deixa as pessoas mais interessantis.",
                    Price = 90
                },
            };
        }
    }

    public enum ChargeType
    {
        Monthly,
        Yearly
    }
}
