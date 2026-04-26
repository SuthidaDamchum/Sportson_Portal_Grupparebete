export type OrderItem = {
  ProductName: string;
  PartNo: string;
  Color: string;
  Size: string;
  QtyOrdered: number;
  GrossAmount: number;
  ImageLink: string;
}

export type Customer = {
  FirstName: string;
  LastName: string;
  Email: string;
  Phone: string;
  Company: string;
}

export type Shop = {
  Name: string;
  City: string;
}

export type OrderHead = {
  OrderNo: string;
  OrderDate: string;
  OrderStatusText: string;
  OrderType: string;
  FailedRulesCheck: boolean;
  FailedRulesMessages: string[];
  TotalGrossAmount: number;
  Customer: Customer;
  NewShop: Shop;
}

export type Order = {
  OrderHead: OrderHead;
  Items: OrderItem[];
}