using MosEisleyCantina.Data.Repositories.Entities;
using MosEisleyCantina.Service.Services.Models.ReferenceData;
using MosEisleyCantina.Service.Services.Models.Requests;
using MosEisleyCantina.Service.Services.Models.Responses;

namespace MosEisleyCantina.Service.Services.Mappers
{
    public static class MenuMappers
    {
        public static MenuItemsResponse MapToMenuItemsResponse(this List<MenuItem> menuItems)
        {
            MenuItemsResponse menuItemsResponse = new MenuItemsResponse();

            foreach (var menuItem in menuItems)
            {
                menuItemsResponse.menuItems.Add(new MenuItemModel()
                {
                    Id = menuItem.Id,
                    Name = menuItem.Name,
                    Description = menuItem.Description,
                    Price = menuItem.Price,
                    Image = menuItem.Image
                });
            }

            return menuItemsResponse;
        }

        public static MenuItemModel MapToMenuItemResponse(this MenuItem menuItem)
        {
            MenuItemModel menuItemResponse = new MenuItemModel()
            {
                Id = menuItem.Id,
                Name = menuItem.Name,
                Description = menuItem.Description,
                Price = menuItem.Price,
                Image = menuItem.Image
            };

            return menuItemResponse;
        }

        public static MenuItem MapToMenuItemRequest(this MenuItemRequest menuItemRequest)
        {
            MenuItem menuItem = new MenuItem()
            {
                Name = menuItemRequest.Name,
                Description = menuItemRequest.Description,
                Price = menuItemRequest.Price,
                Image = menuItemRequest.Image,
                CategoryId = menuItemRequest.CategoryId
            };

            return menuItem;
        }

        public static MenuItem MapToMenuItemUpdateRequest(this MenuItemRequest menuItemRequest)
        {
            MenuItem menuItem = new MenuItem()
            {
                Id = menuItemRequest.Id,
                Name = menuItemRequest.Name,
                Description = menuItemRequest.Description,
                Price = menuItemRequest.Price,
                Image = menuItemRequest.Image,
                CategoryId = menuItemRequest.CategoryId
            };

            return menuItem;
        }

        public static Rating MapToRatingRequest(this RatingRequest ratingRequest)
        {
            Rating rating = new Rating()
            {
                RatingValue = ratingRequest.RatingValue,
                Comment = ratingRequest.Comment,
                CreatedAt = DateTime.Now,
                CustomerName = ratingRequest.CustomerName,
                MenuItemId = ratingRequest.MenuItemId
            };

            return rating;
        }
    }
}
