using Application.UseCases.AutomovilEntity.Commands.CreateDummyEntity;
using Application.UseCases.DummyEntity.Commands.DeleteDummyEntity;
using Application.UseCases.DummyEntity.Commands.UpdateDummyEntity;
using Application.UseCases.DummyEntity.Queries.GetAllDummyEntities;
using Application.UseCases.DummyEntity.Queries.GetDummyEntityBy;
using Core.Application;
using HybridDODArchitecture.Application.UseCases.AutomovilEntity.Commands;
using HybridDODArchitecture.Application.UseCases.AutomovilEntity.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

public class AutomovilController(ICommandQueryBus domain) : Controller
{
    private readonly ICommandQueryBus _domain = domain;
    // GET: AutomocilController

    [HttpGet("api/v1/[Controller]")]

    public async Task<IActionResult> GetAll(uint pageIndex = 1, uint pageSize = 10)
    {
        var entities = await _domain.Send(new GetAllAutomovilesQuery() { PageIndex = pageIndex, PageSize = pageSize });

        return Ok(entities);
    }

    [HttpGet("api/v1/[Controller]/{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        if (string.IsNullOrEmpty(id)) return BadRequest();

        var entity = await _domain.Send(new GetAutomovilByIdQuery { ID = id });

        return Ok(entity);
    }

    [HttpGet("api/v1/[Controller]/{Chasis}")]
    public async Task<IActionResult> GetByChasis(string chasis)
    {
        if (string.IsNullOrEmpty(chasis)) return BadRequest();

        var entity = await _domain.Send(new GetAutomovilByChasisQuery { NUMEROCHASIS = chasis });

        return Ok(entity);
    }

    [HttpPost("api/v1/[Controller]")]
    public async Task<IActionResult> Create(CreateAutomovilCommand command)
    {
        if (command is null) return BadRequest();

        var id = await _domain.Send(command);

        return Created($"api/[Controller]/{id}", new { Id = id });
    }

    [HttpDelete("api/v1/[Controller]/{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        if (id == null) return BadRequest();

        await _domain.Send(new DeleteAutomovilCommand { ID = id });

        return NoContent();
    }

    [HttpPut("api/v1/[Controller]")]
    public async Task<IActionResult> Update(UpdateAutomovilCommand command)
    {
        if (command is null) return BadRequest();

        await _domain.Send(command);

        return NoContent();
    }






}


