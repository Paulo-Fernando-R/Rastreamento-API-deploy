﻿namespace Core.Infra.Models
{
    public class DeliveryModel
    {
        public int DeliveryId { get; set; }
        public string Observation { get; set; }
        public string Description { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }

        public DeliveryModel() 
        {
            Observation = string.Empty;
            Description = string.Empty;
            Origin = string.Empty;
            Destination = string.Empty;
        }

        public DeliveryModel(int deliveryId, string observation, string description, string origin, string destination)
        {
            DeliveryId=deliveryId;
            Observation=observation;
            Description=description;
            Origin=origin;
            Destination=destination;
        }
    }
}