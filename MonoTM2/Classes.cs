﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
/*
 * все закоменченное можно раскомментить
 * 
 *  
 */
namespace MonoTM2
{
    [Serializable]
    class WS
    {
        public string wsAuth { get; set; }
        public bool success { get; set; }
        public string error { get; set; }
    }
    //Баланс
    [Serializable]
    class Money
    {
        public int money { get; set; }
        public string error { get; set; }
    }
    //

    //Ответ покупки
    [Serializable]
    class aBuy
    {
        public string result { get; set; }
        public string id { get; set; }
        public string error { get; set; }
    }
    //

    //Онлайн статус
    [Serializable]
    class Ping
    {
        public bool success { get; set; }
        public string ping { get; set; }
        public string error { get; set; }
    }
    //

    //Выставленные вещи на продажу
    [Serializable]
    public class Trades
    {
        public List<Item> items { get; set; }
    }

    [Serializable]
    public class AppData
    {
        public string def_index { get; set; }
        public int is_itemset_name { get; set; }
    }

    [Serializable]
    public class IDescription
    {
        public string type { get; set; }
        public string value { get; set; }
        //    public string color { get; set; }
        public AppData app_data { get; set; }
    }

    [Serializable]
    public class Item
    {
        public string ui_id { get; set; }
        public string i_name { get; set; }
        //public string i_name_color { get; set; }
        // public string i_rarity { get; set; }
        //   public List<IDescription> i_descriptions { get; set; }
        public string ui_status { get; set; }
        //          public string he_name { get; set; }
        public double ui_price { get; set; }
        public string i_classid { get; set; }
        public string i_instanceid { get; set; }
        public string i_quality { get; set; }
        //            public string i_market_hash_name { get; set; }
        public string i_market_name { get; set; }
        public double i_market_price { get; set; }
        //            public int position { get; set; }
        public int min_price { get; set; }
        //           public string ui_bid { get; set; }
        //           public string type { get; set; }
        public string ui_price_text { get; set; }
        public object min_price_text { get; set; }
        public string i_market_price_text { get; set; }
    }
    ////

    //информация о предмете

    [Serializable]
    public class Value
    {
        public string name { get; set; }
        public string link { get; set; }
        //     public int link_updated { get; set; }
        //   public bool link_true { get; set; }
    }

    [Serializable]
    public class Tag
    {
        public string internal_name { get; set; }
        public string name { get; set; }
        //  public string category { get; set; }
        // public string category_name { get; set; }
        //   public string color { get; set; }
        public List<Value> value { get; set; }
    }

    [Serializable]
    public class Offer
    {
        //    public string __invalid_name__0 { get; set; }
        public string price { get; set; }
        //      public string __invalid_name__1 { get; set; }
        public string count { get; set; }
    }

    [Serializable]
    public class Info
    {
        //   public string classid { get; set; }
        //    public string instanceid { get; set; }
        //  public string market_name { get; set; }
        public string name { get; set; }
        //    public string market_hash_name { get; set; }
        //       public string rarity { get; set; }
        public string quality { get; set; }
        //      public string type { get; set; }
        //     public string mtype { get; set; }
        //    public string slot { get; set; }
        //   public List<IDescription> description { get; set; }
        //   public List<Tag> tags { get; set; }
        public string hash { get; set; }
        public string min_price { get; set; }
        //public List<Offer> offers { get; set; }
    }
    //

    //класс вещей в поиске
    [Serializable]
    public class Itm
    {

        public string name { get; set; }
        public string link { get; set; }
        public double price { get; set; }
        /// <summary>
        /// Format: [classid]_[instanceid]
        /// </summary>
        public string hash { get; set; }
        public string id { get; set; }
        public double profit { get; set; } = 0;
        //public bool turn { get; set; }
        public PriceCheck priceCheck { get; set; } = PriceCheck.Price;
    }
    [Serializable]
    public class WSItm
    {

        public string type { get; set; }
        public WSI data { get; set; }
    }
    [Serializable]
    public class WSI
    {
        //    public string i_quality { get; set; }
        //      public string i_name_color { get; set; }
        public string i_classid { get; set; }
        public string i_instanceid { get; set; }
        public string i_market_hash_name { get; set; }
        //        public string i_market_name { get; set; }
        public double ui_price { get; set; }
        //    public string app { get; set; }

    }

    public class Trade
    {
        public bool success { get; set; }
        public string trade { get; set; }
        public string nick { get; set; }
        public int botid { get; set; }
        public string profile { get; set; }
        public string secret { get; set; }
        public string error { get; set; }
    }



    public class Data
    {
        public string id { get; set; }
        public int status { get; set; }
    }

    public class TrOf
    {
        public string type { get; set; }
        public Data data { get; set; }
    }
    public class TradeOffer
    {
        public string ui_id { get; set; }
        public string ui_status { get; set; }
        public string ui_bid { get; set; }

    }

    //telegram
    public class From
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string username { get; set; }
    }

    public class Chat
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string username { get; set; }
        public string type { get; set; }
    }

    public class Message
    {
        public int message_id { get; set; }
        public From from { get; set; }
        public Chat chat { get; set; }
        public int date { get; set; }
        public string text { get; set; }
    }

    public class Result
    {
        public int update_id { get; set; }
        public Message message { get; set; }
    }

    public class Telegram
    {
        public bool ok { get; set; }
        public List<Result> result { get; set; }
    }


    public class DataOut
    {
        public string ui_status { get; set; }
        public bool clear { get; set; }
    }

    public class ItemOut
    {
        public string type { get; set; }
        public DataOut data { get; set; }
    }

    //Информация о предмете в бытрой покупке
    public class QItems
    {
        public string ui_id { get; set; }
        public string l_paid { get; set; }
        public string i_classid { get; set; }
        public string i_instanceid { get; set; }
    }

    //Класс быстрых покупок
    public class QData
    {
        public bool success { get; set; }
        public List<QItems> items { get; set; }
    }

    //Ответ от быстрой покупки
    public class QAnswer
    {
        public bool success { get; set; }
    }

    //класс ответа о наличии офферов
    public class MarketTrades
    {
        public bool success { get; set; }
        public List<MarketTradesList> trades { get; set; }
    }

    public class MarketTradesList
    {
        public string dir { get; set; }
        public string trade_id { get; set; }
        public string bot_id { get; set; }
    }


    //История продаж
    public class ItemHistory
    {
        public bool success { get; set; }
       // List<Hist> history { get; set; }
    }
    public class Hist {
        public string l_price { get; set; }
        public string l_time { get; set; }
    }

    public class InventOffersInfo
    {
        public int getCount { get; set; } = 0;
        public int outCount { get; set; } = 0;
}

    public class CNotifications
    {
        public bool success { get; set; }
        public List<NotificationsItems> Notifications;
    }

    public class NotificationsItems
    {
        public string i_classid { get; set; }
        public string i_instanceid { get; set; }
        public string i_market_hash_name { get; set; }
        public string i_market_name { get; set; }
        public string n_val { get; set; }
    }

    ///
    public class MassInfo
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("results")]
        public List<MassInfoResult> Results { get; set; }
    }

    public class MassInfoResult
    {
        [JsonProperty("classid")]
        public string Classid { get; set; }

        [JsonProperty("instanceid")]
        public string Instanceid { get; set; }

        [JsonProperty("sell_offers")]
        public MassInfoOffers SellOffers { get; set; }

        [JsonProperty("history")]
        public MassInfoHistory History { get; set; }

        [JsonProperty("buy_offers")]
        public MassInfoOffers BuyOffers { get; set; }

        [JsonProperty("info")]
        public Info Info { get; set; }
    }

    public class MassInfoHistory
    {
        [JsonProperty("max")]
        public uint Max { get; set; }

        [JsonProperty("average")]
        public uint Average { get; set; }

        [JsonProperty("min")]
        public uint Min { get; set; }

        [JsonProperty("number")]
        public uint Number { get; set; }

        [JsonProperty("history")]
        public List<List<long>> OtherHistory { get; set; }

    }

    public class MassInfoOffers
    {
        [JsonProperty("best_offer")]
        public int BestOffer { get; set; }
    }


    public class MassInfoInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("market_name")]
        public string MarketName { get; set; }

        [JsonProperty("market_hash_name")]
        public string MarketHashName { get; set; }

        [JsonProperty("mtype")]
        public string Mtype { get; set; }

        [JsonProperty("quality")]
        public string Quality { get; set; }

        [JsonProperty("slot")]
        public string Slot { get; set; }

        [JsonProperty("our_market_instanceid")]
        public object OurMarketInstanceid { get; set; }

        [JsonProperty("rarity")]
        public string Rarity { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
    ///



    enum MessageType
    {
        Info,
        Socket,
        GetWeapon,
        GiveWeapon,
        BuyWeapon,
        Timer,
        Error
    }

    public enum PriceCheck
    {
        Price, Notification
    }
}
