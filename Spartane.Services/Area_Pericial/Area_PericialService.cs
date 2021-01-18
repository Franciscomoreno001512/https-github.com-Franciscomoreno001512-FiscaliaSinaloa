using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Area_Pericial;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Area_Pericial
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Area_PericialService : IArea_PericialService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Area_Pericial.Area_Pericial> _Area_PericialRepository;
        #endregion

        #region Ctor
        public Area_PericialService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Area_Pericial.Area_Pericial> Area_PericialRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Area_PericialRepository = Area_PericialRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Area_Pericial.Area_Pericial> SelAll(bool ConRelaciones)
        {
            return this._Area_PericialRepository.Table.ToList();
        }

        public IList<Core.Domain.Area_Pericial.Area_Pericial> SelAllComplete(bool ConRelaciones)
        {
            return this._Area_PericialRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Area_Pericial.Area_Pericial> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Area_PericialRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Area_Pericial.Area_Pericial> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Area_PericialRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Area_Pericial.Area_Pericial> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Area_PericialRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Area_Pericial.Area_PericialPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Area_PericialPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Area_Pericial.Area_Pericial> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Area_PericialRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Area_Pericial.Area_Pericial GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Area_Pericial.Area_Pericial result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Area_PericialInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Area_Pericial.Area_Pericial entity, Spartane.Core.Domain.User.GlobalData Area_PericialInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Area_Pericial.Area_Pericial entity, Spartane.Core.Domain.User.GlobalData Area_PericialInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

