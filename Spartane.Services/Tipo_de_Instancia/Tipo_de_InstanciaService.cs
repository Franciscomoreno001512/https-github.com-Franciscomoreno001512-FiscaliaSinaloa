using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Tipo_de_Instancia;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Tipo_de_Instancia
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Tipo_de_InstanciaService : ITipo_de_InstanciaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Tipo_de_Instancia.Tipo_de_Instancia> _Tipo_de_InstanciaRepository;
        #endregion

        #region Ctor
        public Tipo_de_InstanciaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Tipo_de_Instancia.Tipo_de_Instancia> Tipo_de_InstanciaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Tipo_de_InstanciaRepository = Tipo_de_InstanciaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Tipo_de_Instancia.Tipo_de_Instancia> SelAll(bool ConRelaciones)
        {
            return this._Tipo_de_InstanciaRepository.Table.ToList();
        }

        public IList<Core.Domain.Tipo_de_Instancia.Tipo_de_Instancia> SelAllComplete(bool ConRelaciones)
        {
            return this._Tipo_de_InstanciaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Tipo_de_Instancia.Tipo_de_Instancia> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tipo_de_InstanciaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tipo_de_Instancia.Tipo_de_Instancia> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Tipo_de_InstanciaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tipo_de_Instancia.Tipo_de_Instancia> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tipo_de_InstanciaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tipo_de_Instancia.Tipo_de_InstanciaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Tipo_de_InstanciaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Tipo_de_Instancia.Tipo_de_Instancia> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Tipo_de_InstanciaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tipo_de_Instancia.Tipo_de_Instancia GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Tipo_de_Instancia.Tipo_de_Instancia result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Tipo_de_InstanciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Tipo_de_Instancia.Tipo_de_Instancia entity, Spartane.Core.Domain.User.GlobalData Tipo_de_InstanciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Tipo_de_Instancia.Tipo_de_Instancia entity, Spartane.Core.Domain.User.GlobalData Tipo_de_InstanciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

