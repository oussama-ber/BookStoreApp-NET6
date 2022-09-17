﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookStoreApp.API.Data;
using BookStoreApp.API.Models.Author;
using AutoMapper;
using BookStoreApp.API.Static;

namespace BookStoreApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly BookStoreDbContext _context;
        private readonly IMapper mapper;
        private readonly ILogger<AuthorsController> logger;

        public AuthorsController(BookStoreDbContext context, IMapper mapper, ILogger<AuthorsController> logger)
        {
            _context = context;
            this.mapper = mapper;
            this.logger = logger;
        }

        // GET: api/Authors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AuthorReadOnlyDto>>> GetAuthors()
        {

            try
            {
                var authors = await _context.Authors.ToListAsync();
                var authorDtos = mapper.Map<IEnumerable<AuthorReadOnlyDto>>(authors);

                return Ok(authorDtos);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Error Perfoming GET {nameof(GetAuthors)}");
                return StatusCode(500, Messages.Error500Message);
            }

        }

        // GET: api/Authors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AuthorReadOnlyDto>> GetAuthor(int id)
        {
            throw new Exception("Test");
            try
            {
                var author = await _context.Authors.FindAsync(id);

                if (author == null)
                {
                    logger.LogWarning($"Record Not Found {nameof(GetAuthor)} - ID {id}");
                    return NotFound();
                }
                var authorDto = mapper.Map<AuthorReadOnlyDto>(author);
                return authorDto;
            }
            catch (Exception ex)
            {

                logger.LogError(ex, $"Error Perfoming GET {nameof(GetAuthor)}");
                return StatusCode(500, Messages.Error500Message);
            }
        }

        // PUT: api/Authors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAuthor(int id, AuthorUpdateDto authorDto)
        {
            if (id != authorDto.Id)
            {
                logger.LogWarning($"Update ID invalid {id}  in method : {nameof(PutAuthor)}");
                return BadRequest();
            }
            var author = await _context.Authors.FindAsync(id);

            if (author == null)
            {
                logger.LogWarning($"{nameof(author)} record not found in method {nameof(PutAuthor)} - ID {id}");
                return NotFound();
            }

            mapper.Map(authorDto, author);
            _context.Entry(author).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!await AuthorExists(id))
                {
                    return NotFound();
                }
                else
                {
                    logger.LogError(ex, $"Error Perfoming GET in {nameof(PutAuthor)}");
                    return StatusCode(500, Messages.Error500Message);
                }
            }

            return NoContent();
        }

        // POST: api/Authors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AuthorCreateDto>> PostAuthor(AuthorCreateDto authorDto)
        {
            // instead of using this method we ll use the mapper (for cleaner code)
            //var author = new Author
            //{
            //    Bio = authorDto.Bio,
            //    FirstName = authorDto.FristName,
            //    LastName = authorDto.LastName

            //};
            try
            {
                var author = mapper.Map<Author>(authorDto);
                await _context.Authors.AddAsync(author);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetAuthor", new { id = author.Id }, author);
            }
            catch (Exception ex )
            {

                logger.LogError(ex, $"Error Perfoming POST in {nameof(PostAuthor)}", authorDto);
                return StatusCode(500, Messages.Error500Message);
            }
            
        }

        // DELETE: api/Authors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAuthor(int id)
        {

            try
            {
                var author = await _context.Authors.FindAsync(id);
                if (author == null)
                {
                    logger.LogWarning($"{nameof(author)} record not found in {nameof(DeleteAuthor)} - ID :{id}");
                    return NotFound();
                }

                _context.Authors.Remove(author);
                await _context.SaveChangesAsync();

                return NoContent();
            }
            catch (Exception ex )
            {
                logger.LogError(ex, $"Error Perfoming DELETE in {nameof(DeleteAuthor)}");
                return StatusCode(500, Messages.Error500Message);
            }
            
        }

        private async Task<bool> AuthorExists(int id)
        {
            return await _context.Authors.AnyAsync(e => e.Id == id);
        }
    }
}
