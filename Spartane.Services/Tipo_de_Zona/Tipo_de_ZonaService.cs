using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Tipo_de_Zona;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Tipo_de_Zona
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Tipo_de_ZonaService : ITipo_de_ZonaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Tipo_de_Zona.Tipo_de_Zona> _Tipo_de_ZonaRepository;
        #endregion

        #region Ctor
        public Tipo_de_ZonaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Tipo_de_Zona.Tipo_de_Zona> Tipo_de_ZonaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Tipo_de_ZonaRepository = Tipo_de_ZonaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Tipo_de_Zona.Tipo_de_Zona> SelAll(bool ConRelaciones)
        {
            return this._Tipo_de_ZonaRepository.Table.ToList();
        }

        public IList<Core.Domain.Tipo_de_Zona.Tipo_de_Zona> SelAllComplete(bool ConRelaciones)
        {
            return this._Tipo_de_ZonaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Tipo_de_Zona.Tipo_de_Zona> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tipo_de_ZonaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tipo_de_Zona.Tipo_de_Zona> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Tipo_de_ZonaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tipo_de_Zona.Tipo_de_Zona> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tipo_de_ZonaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tipo_de_Zona.Tipo_de_ZonaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Tipo_de_ZonaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Tipo_de_Zona.Tipo_de_Zona> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Tipo_de_ZonaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tipo_de_Zona.Tipo_de_Zona GetByKey(short Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Tipo_de_Zona.Tipo_de_Zona result=null;
            return result;
        }

        public bool Delete(short Key, Spartane.Core.Domain.User.GlobalData Tipo_de_ZonaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public short Insert(Spartane.Core.Domain.Tipo_de_Zona.Tipo_de_Zona entity, Spartane.Core.Domain.User.GlobalData Tipo_de_ZonaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }

        public short Update(Spartane.Core.Domain.Tipo_de_Zona.Tipo_de_Zona entity, Spartane.Core.Domain.User.GlobalData Tipo_de_ZonaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }
        #endregion
    }
}

