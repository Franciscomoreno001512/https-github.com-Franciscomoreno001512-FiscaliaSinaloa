using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Region;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Region
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class RegionService : IRegionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Region.Region> _RegionRepository;
        #endregion

        #region Ctor
        public RegionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Region.Region> RegionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._RegionRepository = RegionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Region.Region> SelAll(bool ConRelaciones)
        {
            return this._RegionRepository.Table.ToList();
        }

        public IList<Core.Domain.Region.Region> SelAllComplete(bool ConRelaciones)
        {
            return this._RegionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Region.Region> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._RegionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Region.Region> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._RegionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Region.Region> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._RegionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Region.RegionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            RegionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Region.Region> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._RegionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Region.Region GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Region.Region result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData RegionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Region.Region entity, Spartane.Core.Domain.User.GlobalData RegionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Region.Region entity, Spartane.Core.Domain.User.GlobalData RegionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

