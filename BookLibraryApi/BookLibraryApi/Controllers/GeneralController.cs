using ApplicationCore.Entities;
using ApplicationCore.Enums;
using ApplicationCore.Interfaces.Entity;
using AutoMapper;
using Infrastructure.Authorization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryApi.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowMyOrigin")]

    public class GeneralController : Controller
    {
        private readonly ICountryService countryService;
        private readonly ILanguageService languageService;
        private readonly IGenreService genreService;
        private readonly IPublisherService publisherService;
        private readonly IUserService userService;
        private readonly IUserBasketService userBasketService;
        private readonly IMapper mapper;

        public GeneralController(
            ICountryService countryService,
            ILanguageService languageService,
            IGenreService genreService,
            IPublisherService publisherService,
            IUserService userService,
            IUserBasketService userBasketService,
            IMapper mapper)
        {
            this.countryService = countryService;
            this.languageService = languageService;
            this.genreService = genreService;
            this.publisherService = publisherService;
            this.userService = userService;
            this.mapper = mapper;
            this.userBasketService = userBasketService;
        }


        #region Country

        [AllowAnonymous]
        [HttpGet("Countries")]
        public async Task<ActionResult<IEnumerable<CountryModelResponse>>> GetAllCountries()
        {
            var countries = await countryService.GetAllWithSpec();
            return Ok(mapper.Map<List<CountryModelResponse>>(countries));
        }

        [AuthorizeJWT(Role.Admin)]
        [HttpGet("Countries/{id}")]
        public async Task<ActionResult<CountryModelResponse>> GetCountryById(int id)
        {
            var country = await countryService.GetById(id);
            if (country is null)
            {
                return NotFound($"Country with id {id} not found.");
            }
            return Ok(mapper.Map<CountryModelResponse>(country));
        }

        [AuthorizeJWT(Role.Admin)]
        [HttpPost("Countries")]
        public async Task<ActionResult<CountryModelResponse>> AddCountry([FromBody] CountryModelRequest countryModel)
        {
            var country = mapper.Map<Country>(countryModel);

            var countryAdded = await countryService.Add(country);
            return CreatedAtAction(nameof(GetCountryById), new { countryAdded.Id }, countryAdded);
        }

        [AuthorizeJWT(Role.Admin)]
        [HttpPut("Countries")]
        public async Task<ActionResult<CountryModelResponse>> UpdateCountry([FromBody] CountryModelRequest countryModel)
        {
            var item = mapper.Map<Country>(countryModel);

            await countryService.Update(item);
            return CreatedAtAction(nameof(GetCountryById), new { item.Id }, item);
        }

        [AuthorizeJWT(Role.Admin)]
        [HttpDelete("Countries/{id}")]
        public async Task<ActionResult<CountryModelResponse>> DeleteCountry(int id)
        {
            await countryService.DeleteById(id);
            return Ok($"Country with id {id} deleted");
        }
        #endregion

        #region Language

        [AllowAnonymous]
        [HttpGet("Languages")]
        public async Task<ActionResult<IEnumerable<LanguageModelResponse>>> GetAllLanguages()
        {
            var languages = await languageService.GetAllWithSpec();
            return Ok(mapper.Map<List<LanguageModelResponse>>(languages));
        }

        [AuthorizeJWT(Role.Admin)]
        [HttpGet("Languages/{id}")]
        public async Task<ActionResult<LanguageModelResponse>> GetLanguageById(int id)
        {
            var language = await languageService.GetById(id);
            if (language is null)
            {
                return NotFound($"Language with id {id} not found.");
            }
            return Ok(mapper.Map<LanguageModelResponse>(language));
        }

        [AuthorizeJWT(Role.Admin)]
        [HttpPost("Languages")]
        public async Task<ActionResult<LanguageModelResponse>> AddLanguage([FromBody] LanguageModelRequest languageModel)
        {
            var language = mapper.Map<Language>(languageModel);

            var languageAdded = await languageService.Add(language);
            return CreatedAtAction(nameof(GetLanguageById), new { languageAdded.Id }, languageAdded);
        }

        [AuthorizeJWT(Role.Admin)]
        [HttpPut("Languages")]
        public async Task<ActionResult<LanguageModelResponse>> UpdateLanguage([FromBody] LanguageModelRequest languageModel)
        {
            var item = mapper.Map<Language>(languageModel);

            await languageService.Update(item);
            return CreatedAtAction(nameof(GetLanguageById), new { item.Id }, item);
        }

        [AuthorizeJWT(Role.Admin)]
        [HttpDelete("Languages/{id}")]
        public async Task<ActionResult<LanguageModelResponse>> DeleteLanguage(int id)
        {
            await languageService.DeleteById(id);
            return Ok($"Language with id {id} deleted");
        }
        #endregion

        #region Publisher

        [AllowAnonymous]
        [HttpGet("Publishers")]
        public async Task<ActionResult<IEnumerable<PublisherModelResponse>>> GetAllPublishers()
        {
            var publishers = await publisherService.GetAllWithSpec();
            return Ok(mapper.Map<List<PublisherModelResponse>>(publishers));
        }

        [AuthorizeJWT(Role.Admin)]
        [HttpGet("Publishers/{id}")]
        public async Task<ActionResult<PublisherModelResponse>> GetPublisherById(int id)
        {
            var publisher = await publisherService.GetById(id);
            if (publisher is null)
            {
                return NotFound($"Publisher with id {id} not found.");
            }
            return Ok(mapper.Map<PublisherModelResponse>(publisher));
        }

        [AuthorizeJWT(Role.Admin)]
        [HttpPost("Publishers")]
        public async Task<ActionResult<PublisherModelResponse>> AddPublisher([FromBody] PublisherModelRequest publisherModel)
        {
            var publisher = mapper.Map<Publisher>(publisherModel);

            var publisherAdded = await publisherService.Add(publisher);
            return CreatedAtAction(nameof(GetPublisherById), new { publisherAdded.Id }, publisherAdded);
        }

        [AuthorizeJWT(Role.Admin)]
        [HttpPut("Publishers")]
        public async Task<ActionResult<PublisherModelResponse>> UpdatePublisher([FromBody] PublisherModelRequest publisherModel)
        {
            var item = mapper.Map<Publisher>(publisherModel);

            await publisherService.Update(item);
            return CreatedAtAction(nameof(GetPublisherById), new { item.Id }, item);
        }

        [AuthorizeJWT(Role.Admin)]
        [HttpDelete("Publishers/{id}")]
        public async Task<ActionResult<PublisherModelRequest>> DeletePublisher(int id)
        {
            await publisherService.DeleteById(id);
            return Ok($"Publisher with id {id} deleted");
        }
        #endregion

        #region Genres

        [AllowAnonymous]
        [HttpGet("Genres")]
        public async Task<ActionResult<IEnumerable<GenreModelResponse>>> GetGenres()
        {
            var genres = await genreService.GetAllWithSpec();
            return Ok(mapper.Map<List<GenreModelResponse>>(genres));
        }

        [AuthorizeJWT(Role.Admin)]
        [HttpGet("Genres/{id}")]
        public async Task<ActionResult<GenreModelResponse>> GetGenreById(int id)
        {
            var genre = await genreService.GetById(id);
            if (genre is null)
            {
                return NotFound($"Genre with id {id} not found.");
            }
            return Ok(mapper.Map<GenreModelResponse>(genre));
        }

        [AuthorizeJWT(Role.Admin)]
        [HttpPost("Genres")]
        public async Task<ActionResult<GenreModelResponse>> AddGenre([FromBody] GenreModelRequest genreModel)
        {
            var genre = mapper.Map<Genre>(genreModel);

            var genreAdded = await genreService.Add(genre, genreModel.BookIds);
            return CreatedAtAction(nameof(GetGenreById), new { genreAdded.Id }, genreAdded);
        }

        [AuthorizeJWT(Role.Admin)]
        [HttpPut("Genres")]
        public async Task<ActionResult<GenreModelResponse>> UpdateGenre([FromBody] GenreModelRequest genreModel)
        {
            var item = mapper.Map<Genre>(genreModel);

            await genreService.Update(item, genreModel.BookIds);
            return CreatedAtAction(nameof(GetGenreById), new { item.Id }, item);
        }

        [AuthorizeJWT(Role.Admin)]
        [HttpDelete("Genres/{id}")]
        public async Task<ActionResult<GenreModelResponse>> DeleteGenre(int id)
        {
            await genreService.DeleteById(id);
            return Ok($"Genre with id {id} deleted");
        }
        #endregion

    }
}

