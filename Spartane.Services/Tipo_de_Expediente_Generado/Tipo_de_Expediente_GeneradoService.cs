using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Tipo_de_Expediente_Generado;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Tipo_de_Expediente_Generado
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Tipo_de_Expediente_GeneradoService : ITipo_de_Expediente_GeneradoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Tipo_de_Expediente_Generado.Tipo_de_Expediente_Generado> _Tipo_de_Expediente_GeneradoRepository;
        #endregion

        #region Ctor
        public Tipo_de_Expediente_GeneradoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Tipo_de_Expediente_Generado.Tipo_de_Expediente_Generado> Tipo_de_Expediente_GeneradoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Tipo_de_Expediente_GeneradoRepository = Tipo_de_Expediente_GeneradoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Tipo_de_Expediente_Generado.Tipo_de_Expediente_Generado> SelAll(bool ConRelaciones)
        {
            return this._Tipo_de_Expediente_GeneradoRepository.Table.ToList();
        }

        public IList<Core.Domain.Tipo_de_Expediente_Generado.Tipo_de_Expediente_Generado> SelAllComplete(bool ConRelaciones)
        {
            return this._Tipo_de_Expediente_GeneradoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Tipo_de_Expediente_Generado.Tipo_de_Expediente_Generado> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tipo_de_Expediente_GeneradoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tipo_de_Expediente_Generado.Tipo_de_Expediente_Generado> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Tipo_de_Expediente_GeneradoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tipo_de_Expediente_Generado.Tipo_de_Expediente_Generado> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tipo_de_Expediente_GeneradoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tipo_de_Expediente_Generado.Tipo_de_Expediente_GeneradoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Tipo_de_Expediente_GeneradoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Tipo_de_Expediente_Generado.Tipo_de_Expediente_Generado> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Tipo_de_Expediente_GeneradoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tipo_de_Expediente_Generado.Tipo_de_Expediente_Generado GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Tipo_de_Expediente_Generado.Tipo_de_Expediente_Generado result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Tipo_de_Expediente_GeneradoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Tipo_de_Expediente_Generado.Tipo_de_Expediente_Generado entity, Spartane.Core.Domain.User.GlobalData Tipo_de_Expediente_GeneradoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Tipo_de_Expediente_Generado.Tipo_de_Expediente_Generado entity, Spartane.Core.Domain.User.GlobalData Tipo_de_Expediente_GeneradoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

