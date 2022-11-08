﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metalapps_Sales_Automation
{
	public class salesdetails
	{
		private int salesId;
		private string customerName;
		private int noOfUnits;
		private double netAmount;

		public int SalesId
		{
			get
			{
				return salesId;
			}
			set
			{
				salesId = value;
			}
		}

		public string CustomerName
		{
			get
			{
				return customerName;
			}
			set
			{
				customerName = value;
			}
		}
		public int NoOfUnits
		{
			get
			{
				return noOfUnits;
			}
			set
			{
				noOfUnits = value;
				if (noOfUnits <= 5)
					throw new ArgumentOutOfRangeException("No Sales for units below 5");

			}
		}
		public double NetAmount
		{
			get
			{
				return netAmount;
			}
			set
			{
				netAmount = value;
			}
		}
	}
}