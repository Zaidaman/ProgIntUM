﻿namespace Progetto_UI.Services.Shared
{
    public partial class SharedService
    {
        TemplateDbContext _dbContext;

        public SharedService(TemplateDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
