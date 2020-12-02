using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Tipo_de_medios_de_transporte;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Tipo_de_medios_de_transporte
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Tipo_de_medios_de_transporteService : ITipo_de_medios_de_transporteService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Tipo_de_medios_de_transporte.Tipo_de_medios_de_transporte> _Tipo_de_medios_de_transporteRepository;
        #endregion

        #region Ctor
        public Tipo_de_medios_de_transporteService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Tipo_de_medios_de_transporte.Tipo_de_medios_de_transporte> Tipo_de_medios_de_transporteRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Tipo_de_medios_de_transporteRepository = Tipo_de_medios_de_transporteRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Tipo_de_medios_de_transporte.Tipo_de_medios_de_transporte> SelAll(bool ConRelaciones)
        {
            return this._Tipo_de_medios_de_transporteRepository.Table.ToList();
        }

        public IList<Core.Domain.Tipo_de_medios_de_transporte.Tipo_de_medios_de_transporte> SelAllComplete(bool ConRelaciones)
        {
            return this._Tipo_de_medios_de_transporteRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Tipo_de_medios_de_transporte.Tipo_de_medios_de_transporte> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tipo_de_medios_de_transporteRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tipo_de_medios_de_transporte.Tipo_de_medios_de_transporte> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Tipo_de_medios_de_transporteRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tipo_de_medios_de_transporte.Tipo_de_medios_de_transporte> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tipo_de_medios_de_transporteRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tipo_de_medios_de_transporte.Tipo_de_medios_de_transportePagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Tipo_de_medios_de_transportePagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Tipo_de_medios_de_transporte.Tipo_de_medios_de_transporte> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Tipo_de_medios_de_transporteRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tipo_de_medios_de_transporte.Tipo_de_medios_de_transporte GetByKey(short Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Tipo_de_medios_de_transporte.Tipo_de_medios_de_transporte result=null;
            return result;
        }

        public bool Delete(short Key, Spartane.Core.Domain.User.GlobalData Tipo_de_medios_de_transporteInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public short Insert(Spartane.Core.Domain.Tipo_de_medios_de_transporte.Tipo_de_medios_de_transporte entity, Spartane.Core.Domain.User.GlobalData Tipo_de_medios_de_transporteInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }

        public short Update(Spartane.Core.Domain.Tipo_de_medios_de_transporte.Tipo_de_medios_de_transporte entity, Spartane.Core.Domain.User.GlobalData Tipo_de_medios_de_transporteInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }
        #endregion
    }
}

