using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Modulo_Servicio_Pericial;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Modulo_Servicio_Pericial
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Modulo_Servicio_PericialService : IModulo_Servicio_PericialService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Modulo_Servicio_Pericial.Modulo_Servicio_Pericial> _Modulo_Servicio_PericialRepository;
        #endregion

        #region Ctor
        public Modulo_Servicio_PericialService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Modulo_Servicio_Pericial.Modulo_Servicio_Pericial> Modulo_Servicio_PericialRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Modulo_Servicio_PericialRepository = Modulo_Servicio_PericialRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Modulo_Servicio_Pericial.Modulo_Servicio_Pericial> SelAll(bool ConRelaciones)
        {
            return this._Modulo_Servicio_PericialRepository.Table.ToList();
        }

        public IList<Core.Domain.Modulo_Servicio_Pericial.Modulo_Servicio_Pericial> SelAllComplete(bool ConRelaciones)
        {
            return this._Modulo_Servicio_PericialRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Modulo_Servicio_Pericial.Modulo_Servicio_Pericial> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Modulo_Servicio_PericialRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Modulo_Servicio_Pericial.Modulo_Servicio_Pericial> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Modulo_Servicio_PericialRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Modulo_Servicio_Pericial.Modulo_Servicio_Pericial> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Modulo_Servicio_PericialRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Modulo_Servicio_Pericial.Modulo_Servicio_PericialPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Modulo_Servicio_PericialPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Modulo_Servicio_Pericial.Modulo_Servicio_Pericial> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Modulo_Servicio_PericialRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Modulo_Servicio_Pericial.Modulo_Servicio_Pericial GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Modulo_Servicio_Pericial.Modulo_Servicio_Pericial result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Modulo_Servicio_PericialInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Modulo_Servicio_Pericial.Modulo_Servicio_Pericial entity, Spartane.Core.Domain.User.GlobalData Modulo_Servicio_PericialInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Modulo_Servicio_Pericial.Modulo_Servicio_Pericial entity, Spartane.Core.Domain.User.GlobalData Modulo_Servicio_PericialInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

