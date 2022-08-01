﻿using ApplicationCore.Authentication;
using ApplicationCore.Entities;
using ApplicationCore.Enums;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Entity;
using ApplicationCore.Specifications.Users;
using AutoMapper;
using BookLibraryApi.Models;
using BookLibraryApi.Models.Country;
using BookLibraryApi.Models.Genre;
using BookLibraryApi.Models.Language;
using BookLibraryApi.Models.Publisher;
using BookLibraryApi.Models.User;
using BookLibraryApi.Models.UserBasket;
using Infrastructure.Authorization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryApi.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowMyOrigin")]

    public class AdminController : Controller
    {
        //private readonly IBookLibraryService bookLibraryService;
        private readonly ICountryService countryService;
        private readonly ILanguageService languageService;
        private readonly IGenreService genreService;
        private readonly IPublisherService publisherService;
        private readonly IUserService userService;
        private readonly IUserBasketService userBasketService;
        private readonly IMapper mapper;
        private readonly IUserServiceJWT userServiceJWT;

        public AdminController(
            ICountryService countryService,
            ILanguageService languageService,
            IGenreService genreService,
            IPublisherService publisherService,
            IUserService userService,
            IUserBasketService userBasketService,
            IMapper mapper,
            IUserServiceJWT userServiceJWT)
        {
            this.countryService = countryService;
            this.languageService = languageService;
            this.genreService = genreService;
            this.publisherService = publisherService;
            this.userService = userService;
            this.mapper = mapper;
            this.userBasketService = userBasketService;
            this.userServiceJWT = userServiceJWT;
        }

        // Auth
        [AllowAnonymous]
        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult<AuthenticateRequestJWT>> Authenticate([FromBody] AuthenticateRequestJWT authenticateRequest)
        {
            var response = await userServiceJWT.Authenticate(authenticateRequest);

            return Ok(response);
        }

        #region Country

        //Country
        [AllowAnonymous]
        [HttpGet("Countries")]
        public async Task<ActionResult<IEnumerable<CountryModel>>> GetAllCountries()
        {
            var countries = await countryService.GetAllWithSpec();
            return Ok(mapper.Map<List<CountryModel>>(countries));
        }
        [AllowAnonymous]
        [HttpGet("Countries/{id}")]
        public async Task<ActionResult<IEnumerable<CountryModel>>> GetCountryById(int id)
        {
            var countries = await countryService.GetAllWith();
            foreach(var country1 in countries)
            {
                if(country1.Id == id)
                    return Ok(mapper.Map<CountryModel>(country1));
            }
            return NotFound($"Country with id {id} not found.");
            //var country = await bookLibraryService.GetCountryById(id);
            //if (country is null)
            //{
            //    return NotFound($"Country with id {id} not found.");
            //}
            //var countryModel = mapper.Map<CountryModel>(country);
            //return Ok(countryModel);
        }
        [AuthorizeJWT(Role.Admin)]
        [HttpPost("Countries")]
        public async Task<ActionResult<CountryModel>> AddCountry([FromBody] CountryPostModel countryPostModel)
        {
            var countries = mapper.Map<Country>(countryPostModel);
            var countriesAdded = await countryService.Add(countries);

            return CreatedAtAction(nameof(GetCountryById), new { countriesAdded.Id }, countriesAdded);
        }

        [AuthorizeJWT(Role.Admin)]
        [HttpPut("Countries")]
        public async Task<ActionResult<CountryModel>> UpdateCountry([FromBody] CountryPutModel countryPutModel)
        {
            var item = mapper.Map<Country>(countryPutModel);
            await countryService.Update(item);
            return CreatedAtAction(nameof(GetCountryById), new { item.Id }, item);
        }
        
        [AuthorizeJWT(Role.Admin)]
        [HttpDelete("Countries/{id}")]
        public async Task<ActionResult<CountryModel>> DeleteCountryById(int id)
        {
            await countryService.DeleteById(id);
            return Ok($"Country with id {id} deleted");
        }
        #endregion

        #region Genre

        //Genre
        [AllowAnonymous]
        [HttpGet("Genres")]
        public async Task<ActionResult<IEnumerable<GenreModel>>> GetAllGenres()
        {
            var genres = await genreService.GetAllWithSpec();
            return Ok(mapper.Map<List<GenreModel>>(genres));
        }
        [AllowAnonymous]
        [HttpGet("Genres/{id}")]
        public async Task<ActionResult<IEnumerable<GenreModel>>> GetGenreById(int id)
        {
            var genres = await genreService.GetAllWith();
            foreach (var genre in genres)
            {
                if (genre.Id == id)
                    return Ok(mapper.Map<GenreModel>(genre));
            }
            return NotFound($"Genre with id {id} not found.");
        }
        [AuthorizeJWT(Role.Admin)]
        [HttpPost("Genres")]
        public async Task<ActionResult<GenreModel>> AddGenre([FromBody] GenrePostModel genrePostModel)
        {
            var genres = mapper.Map<Genre>(genrePostModel);
            var genresAdded = await genreService.Add(genres);

            return CreatedAtAction(nameof(GetGenreById), new { genresAdded.Id }, genresAdded);
        }
        [AuthorizeJWT(Role.Admin)]
        [HttpPut("Genres")]
        public async Task<ActionResult<GenreModel>> UpdateGenre([FromBody] GenrePutModel genrePutModel)
        {
            var item = mapper.Map<Genre>(genrePutModel);
            await genreService.Update(item);
            return CreatedAtAction(nameof(GetGenreById), new { item.Id }, item);
        }
        [AuthorizeJWT(Role.Admin)]
        [HttpDelete("Genres/{id}")]
        public async Task<ActionResult<GenreModel>> DeleteGenreById(int id)
        {
            await genreService.DeleteById(id);
            return Ok($"Genre with id {id} deleted");
        }
        #endregion

        #region Language

        //Language
        [AllowAnonymous]
        [HttpGet("Languages")]
        public async Task<ActionResult<IEnumerable<LanguageModel>>> GetAllLanguages()
        {
            var languages = await languageService.GetAllWithSpec();
            return Ok(mapper.Map<List<LanguageModel>>(languages));
        }

        [AllowAnonymous]
        [HttpGet("Languages/{id}")]
        public async Task<ActionResult<IEnumerable<LanguageModel>>> GetLanguageById(int id)
        {
            var languages = await languageService.GetAllWith();
            foreach (var language in languages)
            {
                if (language.Id == id)
                    return Ok(mapper.Map<LanguageModel>(language));
            }
            return NotFound($"Language with id {id} not found.");
        }
        [AuthorizeJWT(Role.Admin)]
        [HttpPost("Languages")]
        public async Task<ActionResult<LanguageModel>> AddLanguage([FromBody] LanguagePostModel languagePostModel)
        {
            var languages = mapper.Map<Language>(languagePostModel);
            var languagesAdded = await languageService.Add(languages);

            return CreatedAtAction(nameof(GetLanguageById), new { languagesAdded.Id }, languagesAdded);
        }
        [AuthorizeJWT(Role.Admin)]
        [HttpPut("Languages")]
        public async Task<ActionResult<LanguageModel>> UpdateLanguage([FromBody] LanguagePutModel languagePutModel)
        {
            var item = mapper.Map<Language>(languagePutModel);
            await languageService.Update(item);
            return CreatedAtAction(nameof(GetLanguageById), new { item.Id }, item);
        }
        [AuthorizeJWT(Role.Admin)]
        [HttpDelete("Languages/{id}")]
        public async Task<ActionResult<LanguageModel>> DeleteLanguageById(int id)
        {
            await languageService.DeleteById(id);
            return Ok($"Language with id {id} deleted");
        }
        #endregion

        #region Publisher

        //Publisher
        [AllowAnonymous]
        [HttpGet("Publishers")]
        public async Task<ActionResult<IEnumerable<PublisherModel>>> GetAllPublishers()
        {
            var publishers = await publisherService.GetAllWithSpec();
            return Ok(mapper.Map<List<PublisherModel>>(publishers));
        }
        [AllowAnonymous]
        [HttpGet("Publishers/{id}")]
        public async Task<ActionResult<IEnumerable<PublisherModel>>> GetPublisherById(int id)
        {
            var publishers = await publisherService.GetAllWith();
            foreach (var publisher in publishers)
            {
                if (publisher.Id == id)
                    return Ok(mapper.Map<PublisherModel>(publisher));
            }
            return NotFound($"Publisher with id {id} not found.");
        }
        [AuthorizeJWT(Role.Admin)]
        [HttpPost("Publishers")]
        public async Task<ActionResult<PublisherModel>> AddPublisher([FromBody] PublisherPostModel publisherPostModel)
        {
            var publisher = mapper.Map<Publisher>(publisherPostModel);
            var publishersAdded = await publisherService.Add(publisher);
            return CreatedAtAction(nameof(GetPublisherById), new { publishersAdded.Id }, publishersAdded);

        }
        [AuthorizeJWT(Role.Admin)]
        [HttpPut("Publishers")]
        public async Task<ActionResult<PublisherModel>> UpdatePublisher([FromBody] PublisherPutModel publisherPutModel)
        {
            var item = mapper.Map<Publisher>(publisherPutModel);
            await publisherService.Update(item);
            return CreatedAtAction(nameof(GetPublisherById), new { item.Id }, item);
        }
        [AuthorizeJWT(Role.Admin)]
        [HttpDelete("Publishers/{id}")]
        public async Task<ActionResult<PublisherModel>> DeletePublisherById(int id)
        {
            await publisherService.DeleteById(id);
            return Ok($"Publisher with id {id} deleted");
        }
        #endregion

        #region User

        //User
        [AllowAnonymous]
        [HttpGet("Users")]
        public async Task<ActionResult<IEnumerable<UserModel>>> GetAllUsers()
        {
            var specification = new UserWithOrdersWithBooksSpecification();
            var users = await userService.GetAllWithSpec(specification);
            return Ok(mapper.Map<List<UserModel>>(users));
        }
        [AllowAnonymous]
        [HttpGet("Users/{id}")]
        public async Task<ActionResult<IEnumerable<UserModel>>> GetUserById(int id)
        {
            var specification = new UserWithOrdersWithBooksSpecification();
            var users = await userService.GetAllWithSpec(specification);
            foreach (var user in users)
            {
                if (user.Id == id)
                    return Ok(mapper.Map<UserModel>(user));
            }
            return NotFound($"User with id {id} not found.");
        }
        [AuthorizeJWT(Role.Admin)]
        [HttpPost("Users")]
        public async Task<ActionResult<UserModel>> AddUser([FromBody] UserPostModel userPostModel)
        {
            var user = mapper.Map<User>(userPostModel);
            var userAdded = await userService.Add(user);
            return CreatedAtAction(nameof(GetUserById), new { userAdded.Id }, userAdded);
        }
        [AuthorizeJWT(Role.Admin)]
        [HttpPut("Users")]
        public async Task<ActionResult<UserModel>> UpdateUser([FromBody] UserPutModel userPutModel)
        {
            var item = mapper.Map<User>(userPutModel);
            await userService.Update(item);
            return CreatedAtAction(nameof(GetUserById), new { item.Id }, item);
        }
        [AuthorizeJWT(Role.Admin)]
        [HttpDelete("Users/{id}")]
        public async Task<ActionResult<UserModel>> DeleteUserById(int id)
        {
            await userService.DeleteById(id);
            return Ok($"User with id {id} deleted");
        }
        #endregion

        #region UserBasket

        //UserBasket
        [AllowAnonymous]
        [HttpGet("UserBaskets")]
        public async Task<ActionResult<IEnumerable<UserBasketModel>>> GetAllUserBaskets()
        {
            var userBaskets = await userBasketService.GetAllWithSpec();
            return Ok(mapper.Map<List<UserBasketModel>>(userBaskets));
        }
        [AllowAnonymous]
        [HttpGet("UserBaskets/{id}")]
        public async Task<ActionResult<IEnumerable<UserBasketModel>>> GetUserBasketById(int id)
        {
            var userBaskets = await userBasketService.GetAllWith();
            foreach (var userBasket in userBaskets)
            {
                if (userBasket.Id == id)
                    return Ok(mapper.Map<UserBasketModel>(userBasket));
            }
            return NotFound($"UserBasket with id {id} not found.");
        }
        [AuthorizeJWT(Role.Admin)]
        [HttpPost("UserBaskets")]
        public async Task<ActionResult<UserBasketModel>> AddUserBasket([FromBody] UserBasketPostModel userBasketPostModel)
        {
            var userBasket = mapper.Map<UserBasket>(userBasketPostModel);
            var userBasketAdded = await userBasketService.Add(userBasket);
            return CreatedAtAction(nameof(GetUserBasketById), new { userBasketAdded.Id }, userBasketAdded);
        }
        [AuthorizeJWT(Role.Admin)]
        [HttpPut("UserBaskets")]
        public async Task<ActionResult<UserBasketModel>> UpdateUserBasket([FromBody] UserBasketPutModel userBasketPutModel)
        {
            var item = mapper.Map<UserBasket>(userBasketPutModel);
            await userBasketService.Update(item);
            return CreatedAtAction(nameof(GetUserBasketById), new { item.Id }, item);
        }
        [AuthorizeJWT(Role.Admin)]
        [HttpDelete("UserBaskets/{id}")]
        public async Task<ActionResult<UserBasketModel>> DeleteUserBasketById(int id)
        {
            await userBasketService.DeleteById(id);
            return Ok($"UserBasket with id {id} deleted");
        }
        #endregion

        //SystemSettings
        //[HttpGet("/System Settings/All")]
        //public async Task<ActionResult<IEnumerable<Genre>>> GetSettings()
        //{
        //    var authors = await bookLibraryService.GetAllAuthors();
        //    return Ok(mapper.Map<List<AuthorModel>>(authors));
        //}
        //[HttpPost("/System Settings/Add Settings")]
        //public async Task<ActionResult<IEnumerable<Genre>>> PostSetting()
        //{
        //    var authors = await bookLibraryService.GetAllAuthors();
        //    return Ok(mapper.Map<List<AuthorModel>>(authors));
        //}
        //[HttpPut("/System Settings/Update Settings")]
        //public async Task<ActionResult<IEnumerable<Genre>>> PutSetting()
        //{
        //    var authors = await bookLibraryService.GetAllAuthors();
        //    return Ok(mapper.Map<List<AuthorModel>>(authors));
        //}
        //[HttpDelete("/System Settings/Delete Settings")]
        //public async Task<ActionResult<IEnumerable<Genre>>> DeleteSetting()
        //{
        //    var authors = await bookLibraryService.GetAllAuthors();
        //    return Ok(mapper.Map<List<AuthorModel>>(authors));
        //}

    }
}

