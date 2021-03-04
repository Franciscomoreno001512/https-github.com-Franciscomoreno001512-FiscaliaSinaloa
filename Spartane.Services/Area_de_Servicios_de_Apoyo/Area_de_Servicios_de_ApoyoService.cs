using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Area_de_Servicios_de_Apoyo;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Area_de_Servicios_de_Apoyo
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Area_de_Servicios_de_ApoyoService : IArea_de_Servicios_de_ApoyoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo> _Area_de_Servicios_de_ApoyoRepository;
        #endregion

        #region Ctor
        public Area_de_Servicios_de_ApoyoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo> Area_de_Servicios_de_ApoyoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Area_de_Servicios_de_ApoyoRepository = Area_de_Servicios_de_ApoyoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo> SelAll(bool ConRelaciones)
        {
            return this._Area_de_Servicios_de_ApoyoRepository.Table.ToList();
        }

        public IList<Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo> SelAllComplete(bool ConRelaciones)
        {
            return this._Area_de_Servicios_de_ApoyoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Area_de_Servicios_de_ApoyoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Area_de_Servicios_de_ApoyoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Area_de_Servicios_de_ApoyoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_ApoyoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Area_de_Servicios_de_ApoyoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Area_de_Servicios_de_ApoyoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Area_de_Servicios_de_ApoyoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo entity, Spartane.Core.Domain.User.GlobalData Area_de_Servicios_de_ApoyoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Area_de_Servicios_de_Apoyo.Area_de_Servicios_de_Apoyo entity, Spartane.Core.Domain.User.GlobalData Area_de_Servicios_de_ApoyoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

