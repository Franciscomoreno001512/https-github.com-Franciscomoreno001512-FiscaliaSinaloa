using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Recepcionistas;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Recepcionistas
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class RecepcionistasService : IRecepcionistasService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Recepcionistas.Recepcionistas> _RecepcionistasRepository;
        #endregion

        #region Ctor
        public RecepcionistasService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Recepcionistas.Recepcionistas> RecepcionistasRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._RecepcionistasRepository = RecepcionistasRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Recepcionistas.Recepcionistas> SelAll(bool ConRelaciones)
        {
            return this._RecepcionistasRepository.Table.ToList();
        }

        public IList<Core.Domain.Recepcionistas.Recepcionistas> SelAllComplete(bool ConRelaciones)
        {
            return this._RecepcionistasRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Recepcionistas.Recepcionistas> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._RecepcionistasRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Recepcionistas.Recepcionistas> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._RecepcionistasRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Recepcionistas.Recepcionistas> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._RecepcionistasRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Recepcionistas.RecepcionistasPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            RecepcionistasPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Recepcionistas.Recepcionistas> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._RecepcionistasRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Recepcionistas.Recepcionistas GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Recepcionistas.Recepcionistas result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData RecepcionistasInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Recepcionistas.Recepcionistas entity, Spartane.Core.Domain.User.GlobalData RecepcionistasInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Recepcionistas.Recepcionistas entity, Spartane.Core.Domain.User.GlobalData RecepcionistasInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

