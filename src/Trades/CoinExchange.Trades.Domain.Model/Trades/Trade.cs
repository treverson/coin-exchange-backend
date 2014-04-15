﻿using System;

namespace CoinExchange.Trades.Domain.Model.Trades
{
    /// <summary>
    /// Result of a bid and ask crossing
    /// </summary>
    public class Trade
    {
        private readonly string _aggregateId;
        private string _currencyPair = string.Empty;
        private decimal _executionPrice = 0;
        private decimal _executedQuantity = 0;
        private DateTime _executionTime = DateTime.MinValue;
        private Order.Order _buyOrder = null;
        private Order.Order _sellOrder = null;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Trade(string currencyPair, decimal executionPrice, decimal executedQuantity, DateTime executionTime,
            Order.Order buyOrder, Order.Order sellOrder)
        {
            _currencyPair = currencyPair;
            _executionPrice = executionPrice;
            _executedQuantity = executedQuantity;
            _executionTime = executionTime;
            _buyOrder = buyOrder;
            _sellOrder = sellOrder;

            // ToDo: Need to implement auto incremental aggregate Id generator 
        }

        /// <summary>
        /// Raise the TradeExecutedEvent
        /// </summary>
        public void RaiseEvent()
        {
            TradeExecutedEvent tradeExecutedEvent = new TradeExecutedEvent(_aggregateId, this);

            // ToDo: Need to figure out how to raise this event and publish on the output disruptor
        }

        /// <summary>
        /// Currency Pair
        /// </summary>
        public string CurrencyPair
        {
            get { return _currencyPair; }
        }

        /// <summary>
        /// Execution Price
        /// </summary>
        public decimal ExecutionPrice
        {
            get { return _executionPrice; }
        }

        /// <summary>
        /// Executed Quantity
        /// </summary>
        public decimal ExecutedQuantity
        {
            get { return _executedQuantity; }
        }

        /// <summary>
        /// ExecutionTime
        /// </summary>
        public DateTime ExecutionTime
        {
            get { return _executionTime; }
        }

        /// <summary>
        /// Buy Order Reference
        /// </summary>
        public Order.Order BuyOrder
        {
            get { return _buyOrder; }
        }

        /// <summary>
        /// Sell Order Reference
        /// </summary>
        public Order.Order SellOrder
        {
            get { return _sellOrder; }
        }
    }
}