using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_de_Galeria_de_Intervinientes;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_de_Galeria_de_Intervinientes
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_de_Galeria_de_IntervinientesService : IDetalle_de_Galeria_de_IntervinientesService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_de_Galeria_de_Intervinientes.Detalle_de_Galeria_de_Intervinientes> _Detalle_de_Galeria_de_IntervinientesRepository;
        #endregion

        #region Ctor
        public Detalle_de_Galeria_de_IntervinientesService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_de_Galeria_de_Intervinientes.Detalle_de_Galeria_de_Intervinientes> Detalle_de_Galeria_de_IntervinientesRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_de_Galeria_de_IntervinientesRepository = Detalle_de_Galeria_de_IntervinientesRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_de_Galeria_de_Intervinientes.Detalle_de_Galeria_de_Intervinientes> SelAll(bool ConRelaciones)
        {
            return this._Detalle_de_Galeria_de_IntervinientesRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_de_Galeria_de_Intervinientes.Detalle_de_Galeria_de_Intervinientes> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_de_Galeria_de_IntervinientesRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_de_Galeria_de_Intervinientes.Detalle_de_Galeria_de_Intervinientes> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_de_Galeria_de_IntervinientesRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_de_Galeria_de_Intervinientes.Detalle_de_Galeria_de_Intervinientes> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_de_Galeria_de_IntervinientesRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_de_Galeria_de_Intervinientes.Detalle_de_Galeria_de_Intervinientes> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_de_Galeria_de_IntervinientesRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_de_Galeria_de_Intervinientes.Detalle_de_Galeria_de_IntervinientesPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_de_Galeria_de_IntervinientesPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_de_Galeria_de_Intervinientes.Detalle_de_Galeria_de_Intervinientes> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_de_Galeria_de_IntervinientesRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_de_Galeria_de_Intervinientes.Detalle_de_Galeria_de_Intervinientes GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_de_Galeria_de_Intervinientes.Detalle_de_Galeria_de_Intervinientes result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_de_Galeria_de_IntervinientesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_de_Galeria_de_Intervinientes.Detalle_de_Galeria_de_Intervinientes entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Galeria_de_IntervinientesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_de_Galeria_de_Intervinientes.Detalle_de_Galeria_de_Intervinientes entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Galeria_de_IntervinientesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

