using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Partida_que_Cumplimenta;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Partida_que_Cumplimenta
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Partida_que_CumplimentaService : IPartida_que_CumplimentaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta> _Partida_que_CumplimentaRepository;
        #endregion

        #region Ctor
        public Partida_que_CumplimentaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta> Partida_que_CumplimentaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Partida_que_CumplimentaRepository = Partida_que_CumplimentaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta> SelAll(bool ConRelaciones)
        {
            return this._Partida_que_CumplimentaRepository.Table.ToList();
        }

        public IList<Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta> SelAllComplete(bool ConRelaciones)
        {
            return this._Partida_que_CumplimentaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Partida_que_CumplimentaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Partida_que_CumplimentaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Partida_que_CumplimentaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_CumplimentaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Partida_que_CumplimentaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Partida_que_CumplimentaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Partida_que_CumplimentaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta entity, Spartane.Core.Domain.User.GlobalData Partida_que_CumplimentaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Partida_que_Cumplimenta.Partida_que_Cumplimenta entity, Spartane.Core.Domain.User.GlobalData Partida_que_CumplimentaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

