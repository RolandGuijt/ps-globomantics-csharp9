using System;
using Shared.Dtos;
using Shared.Enums;
using Web.ViewModels;

namespace Web.Mappers
{
    public class EventMapper
    {
        public EventPriceViewModel ConvertPriceDtoToViewModel(EventPriceDto dto)
        {
            return new()
            {
                Id = dto.Id,
                Date = dto.Date,
                Name = dto.Name,
                EventType = dto.EventType,
                Venue = dto.Venue,
                PercentageSold = dto.PercentageSold,
                TicketPrice = dto.TicketPrice
            };
        }

        public void CopyBaseProperties(EventViewModel source, EventViewModel destination)
        {
            destination.Date = source.Date;
            destination.Name = source.Name;
            destination.EventType = source.EventType;
            destination.Venue = source.Venue;
            destination.VenueCostType = source.VenueCostType;
            destination.MarketingCostType = source.MarketingCostType;
            destination.Capacity = source.Capacity;
            destination.Sold = source.Sold;
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
            return new ConcertDto(viewModel.Id, viewModel.Date, viewModel.Name, viewModel.EventType, viewModel.Venue,
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