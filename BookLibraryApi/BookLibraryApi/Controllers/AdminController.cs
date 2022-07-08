using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Entity;
using AutoMapper;
using BookLibraryApi.Models;
using BookLibraryApi.Models.Genre;
using BookLibraryApi.Models.Language;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;


//Rijesi modele;
//Popravi order


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
        private readonly IMapper mapper;
        public AdminController(
            ICountryService countryService,
            ILanguageService languageService,
            IGenreService genreService,
            IPublisherService publisherService,
            IUserService userService,
            IMapper mapper)
        {
            this.countryService = countryService;
            this.languageService = languageService;
            this.genreService = genreService;
            this.publisherService = publisherService;
            this.userService = userService;
            this.mapper = mapper;
        }
        
        //Country
        [HttpGet("Country/All")]
        public async Task<ActionResult<IEnumerable<CountryModel>>> GetAllCountries()
        {
            var countries = await countryService.GetAllCountires();
            return Ok(mapper.Map<List<CountryModel>>(countries));
        }
        [HttpGet("Country/{id}")]
        public async Task<ActionResult<IEnumerable<CountryModel>>> GetCountryById(int id)
        {
            var countries = await countryService.GetAllCountires();
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
        [HttpPost("Country")]
        public async Task<ActionResult<CountryModel>> AddCountry([FromBody] CountryModel countryModel)
        {
            var countries = mapper.Map<Country>(countryModel);
            var countriesAdded = await countryService.AddCountry(countries);

            return CreatedAtAction(nameof(GetCountryById), new { countriesAdded.Id }, countriesAdded);
        }
        [HttpPut("Country")]
        public async Task<ActionResult<CountryModel>> UpdateCountry([FromBody] Country country)
        {
            await countryService.UpdateCountry(country);
            return CreatedAtAction(nameof(GetCountryById), new { country.Id }, country);
        }

        [HttpDelete("Country/{id}")]
        public async Task<ActionResult<CountryModel>> DeleteCountryById(int id)
        {
            await countryService.DeleteCountryById(id);
            return Ok($"Country with id {id} deleted");
        }

        //Genre
        [HttpGet("Genre/All")]
        public async Task<ActionResult<IEnumerable<GenreModel>>> GetAllGenres()
        {
            var genres = await genreService.GetAllGenresWith();
            return Ok(mapper.Map<List<GenreModel>>(genres));
        }
        [HttpGet("Genre/{id}")]
        public async Task<ActionResult<IEnumerable<GenreModel>>> GetGenreById(int id)
        {
            var genres = await genreService.GetAllGenresWith();
            foreach (var genre in genres)
            {
                if (genre.Id == id)
                    return Ok(mapper.Map<GenreModel>(genre));
            }
            return NotFound($"Genre with id {id} not found.");
        }
        [HttpPost("Genre")]
        public async Task<ActionResult<GenreModel>> AddGenre([FromBody] GenreModel genreModel)
        {
            var genres = mapper.Map<Genre>(genreModel);
            var genresAdded = await genreService.AddGenre(genres);

            return CreatedAtAction(nameof(GetGenreById), new { genresAdded.Id }, genresAdded);
        }
        [HttpPut("Genre")]
        public async Task<ActionResult<GenreModel>> UpdateGenre([FromBody] GenreModel genreModel)
        {
            var item = mapper.Map<Genre>(genreModel);
            await genreService.UpdateGenre(item);
            return CreatedAtAction(nameof(GetGenreById), new { item.Id }, item);
        }
       
        [HttpDelete("Genre/{id}")]
        public async Task<ActionResult<GenreModel>> DeleteGenreById(int id)
        {
            await genreService.DeleteGenreById(id);
            return Ok($"Genre with id {id} deleted");
        }

        //Language
        [HttpGet("Language/All")]
        public async Task<ActionResult<IEnumerable<LanguageModel>>> GetAllLanguages()
        {
            var languages = await languageService.GetAllLanguagesWith();
            return Ok(mapper.Map<List<LanguageModel>>(languages));
        }
        [HttpGet("Language/{id}")]
        public async Task<ActionResult<IEnumerable<LanguageModel>>> GetLanguageById(int id)
        {
            var languages = await languageService.GetAllLanguagesWith();
            foreach (var language in languages)
            {
                if (language.Id == id)
                    return Ok(mapper.Map<LanguageModel>(language));
            }
            return NotFound($"Language with id {id} not found.");
        }
        [HttpPost("Language")]
        public async Task<ActionResult<LanguageModel>> AddLanguage([FromBody] LanguageModel languageModel)
        {
            var languages = mapper.Map<Language>(languageModel);
            var languagesAdded = await languageService.AddLanguage(languages);

            return CreatedAtAction(nameof(GetLanguageById), new { languagesAdded.Id }, languagesAdded);
        }
        [HttpPut("Language")]
        public async Task<ActionResult<LanguageModel>> UpdateLanguage([FromBody] LanguageModel languageModel)
        {
            var item = mapper.Map<Language>(languageModel);
            await languageService.UpdateLanguage(item);
            return CreatedAtAction(nameof(GetLanguageById), new { item.Id }, item);
        }
        [HttpDelete("Language/{id}")]
        public async Task<ActionResult<LanguageModel>> DeleteLanguageById(int id)
        {
            await languageService.DeleteLanguageById(id);
            return Ok($"Language with id {id} deleted");
        }

        //Publisher
        [HttpGet("Publisher/All")]
        public async Task<ActionResult<IEnumerable<PublisherModel>>> GetAllPublishers()
        {
            var publishers = await publisherService.GetAllPublishersWith();
            return Ok(mapper.Map<List<PublisherModel>>(publishers));
        }
        [HttpGet("Publisher/{id}")]
        public async Task<ActionResult<IEnumerable<PublisherModel>>> GetPublisherById(int id)
        {
            var publishers = await publisherService.GetAllPublishersWith();
            foreach (var publisher in publishers)
            {
                if (publisher.Id == id)
                    return Ok(mapper.Map<PublisherModel>(publisher));
            }
            return NotFound($"Publisher with id {id} not found.");
        }
        [HttpPost("Publisher")]
        public async Task<ActionResult<PublisherModel>> AddPublisher([FromBody] PublisherModel publisherModel)
        {
            var publisher = mapper.Map<Publisher>(publisherModel);
            var publishersAdded = await publisherService.AddPublisher(publisher);
            return CreatedAtAction(nameof(GetPublisherById), new { publishersAdded.Id }, publishersAdded);

        }
        [HttpPut("Publisher")]
        public async Task<ActionResult<PublisherModel>> UpdatePublisher([FromBody] PublisherModel publisherModel)
        {
            var item = mapper.Map<Publisher>(publisherModel);
            await publisherService.UpdatePublisher(item);
            return CreatedAtAction(nameof(GetPublisherById), new { item.Id }, item);
        }
        [HttpDelete("Publisher/{id}")]
        public async Task<ActionResult<PublisherModel>> DeletePublisherById(int id)
        {
            await publisherService.DeletePublisherById(id);
            return Ok($"Publisher with id {id} deleted");
        }

        //User
        [HttpGet("User/All")]
        public async Task<ActionResult<IEnumerable<UserModel>>> GetAllUsers()
        {
            var users = await userService.GetAllUsersWith();
            return Ok(mapper.Map<List<UserModel>>(users));
        }
        [HttpGet("User/{id}")]
        public async Task<ActionResult<IEnumerable<UserModel>>> GetUserById(int id)
        {
            var users = await userService.GetAllUsersWith();
            foreach (var user in users)
            {
                if (user.Id == id)
                    return Ok(mapper.Map<UserModel>(user));
            }
            return NotFound($"User with id {id} not found.");
        }
        [HttpPost("User")]
        public async Task<ActionResult<UserModel>> AddUser([FromBody] UserModel userModel)
        {
            var user = mapper.Map<User>(userModel);
            var userAdded = await userService.AddUser(user);
            return CreatedAtAction(nameof(GetUserById), new { userAdded.Id }, userAdded);

        }
        [HttpPut("User")]
        public async Task<ActionResult<UserModel>> UpdateUser([FromBody] UserModel userModel)
        {
            var item = mapper.Map<User>(userModel);
            await userService.UpdateUser(item);
            return CreatedAtAction(nameof(GetUserById), new { item.Id }, item);
        }
        [HttpDelete("User/{id}")]
        public async Task<ActionResult<UserModel>> DeleteUserById(int id)
        {
            await userService.DeleteUserById(id);
            return Ok($"User with id {id} deleted");
        }

        ////SystemSettings
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

