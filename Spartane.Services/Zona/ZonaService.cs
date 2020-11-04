using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Zona;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Zona
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class ZonaService : IZonaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Zona.Zona> _ZonaRepository;
        #endregion

        #region Ctor
        public ZonaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Zona.Zona> ZonaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._ZonaRepository = ZonaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Zona.Zona> SelAll(bool ConRelaciones)
        {
            return this._ZonaRepository.Table.ToList();
        }

        public IList<Core.Domain.Zona.Zona> SelAllComplete(bool ConRelaciones)
        {
            return this._ZonaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Zona.Zona> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._ZonaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Zona.Zona> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._ZonaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Zona.Zona> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._ZonaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Zona.ZonaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            ZonaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Zona.Zona> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._ZonaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Zona.Zona GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Zona.Zona result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData ZonaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Zona.Zona entity, Spartane.Core.Domain.User.GlobalData ZonaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Zona.Zona entity, Spartane.Core.Domain.User.GlobalData ZonaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

