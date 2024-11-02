using DemoLib.Models;
using DemoLib.Views;
using System;
using System.Collections.Generic;

namespace DemoLib.Presenters
{
    public class ClientPresenter
    {
        private IClientsModel model_;
        private List<IClientView> views_ = new List<IClientView>();

        public ClientPresenter(IClientsModel model)
        {
            model_ = model;

            model_.UpdatedClients += Model__UpdatedClients;
        }

        public void Model__UpdatedClients()
        {
            List<Client> clients = model_.GetClients();
            for (int i = 0; i < clients.Count; i++)
            {
                Client client = clients[i];
                IClientView clientView = views_[i];
                clientView.LoadClient(client);
            }
        }

        public void AddView(IClientView view)
        {
            views_.Add(view);
        }


        public void UpdateClient(Client updatedClient)
        {
          
            Model__UpdatedClients();
            var clients = model_.GetClients();
            foreach (var client in clients)
            {
                if (client.ID == updatedClient.ID)
                {
                    
                    client.Name = updatedClient.Name;
                    client.Director = updatedClient.Director;
                    client.PhoneNumber = updatedClient.PhoneNumber;
                    client.Rating = updatedClient.Rating;
                    client.Discount = updatedClient.Discount;
                    UpdatedClients?.Invoke();
                    break; 
                }

            }

        }

        public event Action UpdatedClients;
    }
}
