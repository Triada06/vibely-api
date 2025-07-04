﻿using FitFlare.Core.Entities;
using FitFlare.Infrastructure.Data;
using FitFlare.Infrastructure.Repositories.Interfaces;

namespace FitFlare.Infrastructure.Repositories;

public class AppUserRepository(AppDbContext context) : BaseRepository<AppUser>(context), IAppUserRepository;