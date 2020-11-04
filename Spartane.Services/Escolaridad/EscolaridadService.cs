using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Escolaridad;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Escolaridad
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class EscolaridadService : IEscolaridadService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Escolaridad.Escolaridad> _EscolaridadRepository;
        #endregion

        #region Ctor
        public EscolaridadService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Escolaridad.Escolaridad> EscolaridadRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._EscolaridadRepository = EscolaridadRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Escolaridad.Escolaridad> SelAll(bool ConRelaciones)
        {
            return this._EscolaridadRepository.Table.ToList();
        }

        public IList<Core.Domain.Escolaridad.Escolaridad> SelAllComplete(bool ConRelaciones)
        {
            return this._EscolaridadRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Escolaridad.Escolaridad> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._EscolaridadRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Escolaridad.Escolaridad> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._EscolaridadRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Escolaridad.Escolaridad> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._EscolaridadRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Escolaridad.EscolaridadPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            EscolaridadPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Escolaridad.Escolaridad> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._EscolaridadRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Escolaridad.Escolaridad GetByKey(short Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Escolaridad.Escolaridad result=null;
            return result;
        }

        public bool Delete(short Key, Spartane.Core.Domain.User.GlobalData EscolaridadInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public short Insert(Spartane.Core.Domain.Escolaridad.Escolaridad entity, Spartane.Core.Domain.User.GlobalData EscolaridadInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }

        public short Update(Spartane.Core.Domain.Escolaridad.Escolaridad entity, Spartane.Core.Domain.User.GlobalData EscolaridadInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }
        #endregion
    }
}

