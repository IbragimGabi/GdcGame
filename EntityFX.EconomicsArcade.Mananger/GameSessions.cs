﻿using EntityFX.EconomicsArcade.Contract.Game;
using EntityFX.EconomicsArcade.Contract.Manager.SessionManager;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EntityFX.EconomicArcade.Engine.GameEngine.UssrSimulator;


namespace EntityFX.EconomicsArcade.Manager
{
    public class GameSessions
    {
        private readonly GameFactory _gameFactory;
        private static readonly IDictionary<string, IGame> GameSessionsStorage = new Dictionary<string, IGame>();

        private static readonly IDictionary<Guid, Session> SessionsStorage = new Dictionary<Guid, Session>();

        private static Timer _timer = new Timer(TimerCallback, null, 0, 1000 );

        public GameSessions(GameFactory gameFactory)
        {
            _gameFactory = gameFactory;
        }

        private static void TimerCallback(object state)
        {
            foreach (var gameSession in GameSessionsStorage)
            {
                gameSession.Value.PerformAutoStep();
            }
        }

        public IGame GetGame(Guid sessionId)
        {
            var session = GetSession(sessionId);
            if (session == null) return null;

            if (!GameSessionsStorage.ContainsKey(session.Login))
            {
                var game = BuildGame();
                game.Initialize();
                GameSessionsStorage.Add(session.Login, game);
            }
            return GameSessionsStorage[session.Login];
        }

        public Guid AddSession(string login)
        {
            var session = new Session()
            {
                Login = login,
                SessionIdentifier = Guid.NewGuid()
            };
            SessionsStorage.Add(session.SessionIdentifier, session);
            return session.SessionIdentifier;
        }

        public Session GetSession(Guid sessionId)
        {
            return !SessionsStorage.ContainsKey(sessionId) ? null : SessionsStorage[sessionId];
        }

        private IGame BuildGame()
        {
            return _gameFactory.BuildGame();
        }
    }
}
