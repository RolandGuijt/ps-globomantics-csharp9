using System;
using Shared.Dtos;
using Web.ViewModels;

namespace Web.Mappers
{
    public class ConferenceEventMapper : EventMapper
    {
        public override ConferenceDto ConvertViewModelToDto(EventViewModel viewModel)
        {
            var conferenceViewModel = (ConferenceViewModel) viewModel;
            return new(viewModel.Id, viewModel.Date, viewModel.Name, viewModel.EventType, viewModel.Venue,
                viewModel.VenueCostType, viewModel.MarketingCostType, viewModel.Capacity, viewModel.Sold,
                conferenceViewModel.BadgeCosts, conferenceViewModel.CateringCosts);
        }
    }
    
    public class EventMapper
    {
        public EventPriceViewModel ConvertPriceDtoToViewModel(EventPriceDto dto)
        {
            var (id, date, name, eventType, venue, percentageSold, price) = dto;

            return new EventPriceViewModel
            {
                Id = id,
                Date = date,
                Name = name,
                EventType = eventType,
                Venue = venue,
                PercentageSold = percentageSold,
                TicketPrice = price
            };
        }

        public void CopyBaseProperties(EventViewModel source, EventViewModel destination, Action<int, EventViewModel> reportProgress)
        {
            destination.Date = source.Date;
            reportProgress(12, destination);
            destination.Name = source.Name;
            reportProgress(24, destination);
            destination.EventType = source.EventType;
            reportProgress(36, destination);
            destination.Venue = source.Venue;
            reportProgress(48, destination);
            destination.VenueCostType = source.VenueCostType;
            reportProgress(60, destination);
            destination.MarketingCostType = source.MarketingCostType;
            reportProgress(72, destination);
            destination.Capacity = source.Capacity;
            reportProgress(84, destination);
            destination.Sold = source.Sold;
            reportProgress(100, destination);
        }

        public virtual EventDto ConvertViewModelToDto(EventViewModel viewModel)
        {
            return new(viewModel.Id, viewModel.Date, viewModel.Name, viewModel.EventType, viewModel.Venue,
                viewModel.VenueCostType, viewModel.MarketingCostType, viewModel.Capacity, viewModel.Sold);
        }
        public ConferenceDto ConvertConferenceViewModelToDto(ConferenceViewModel viewModel)
        {
            return new(viewModel.Id, viewModel.Date, viewModel.Name, viewModel.EventType, viewModel.Venue,
                viewModel.VenueCostType, viewModel.MarketingCostType, viewModel.Capacity, viewModel.Sold,
                viewModel.BadgeCosts, viewModel.CateringCosts);
        }

        public MultiDayConferenceDto ConvertMultiDayConferenceViewModelToDto(MultiDayConferenceViewModel viewModel)
        {
            return new(viewModel.Id, viewModel.Date, viewModel.Name, viewModel.EventType,
                viewModel.Venue, viewModel.VenueCostType, viewModel.MarketingCostType, viewModel.Capacity,
                viewModel.Sold, viewModel.BadgeCosts,
                viewModel.CateringCosts, viewModel.NumberOfDays, viewModel.AccomodationCostType);
        }

        public ConcertDto ConvertConcertViewModelToDto(ConcertViewModel viewModel)
        {
            return new(viewModel.Id, viewModel.Date, viewModel.Name, viewModel.EventType, viewModel.Venue,
                viewModel.VenueCostType, viewModel.MarketingCostType, viewModel.Capacity, viewModel.Sold,
                viewModel.ArtistCosts, viewModel.ArtistCostType);
        }

        public SportsGameDto ConvertSportsGameViewModelToDto(SportsGameViewModel viewModel)
        {
            return new(viewModel.Id, viewModel.Date, viewModel.Name, viewModel.EventType, viewModel.Venue,
                viewModel.VenueCostType, viewModel.MarketingCostType, viewModel.Capacity, viewModel.Sold,
                viewModel.NumberOfPlayers, viewModel.CostsPerPlayer);
        }
    }
}