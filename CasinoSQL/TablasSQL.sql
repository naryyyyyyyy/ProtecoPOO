-- ============================================================================
-- 1. LIMPIEZA TOTAL (En orden inverso para no romper las llaves foráneas)
-- ============================================================================
DROP TABLE IF EXISTS historial_juegos;
DROP TABLE IF EXISTS personajes_guardados;
DROP TABLE IF EXISTS usuarios;
DROP TABLE IF EXISTS administradores;
DROP TABLE IF EXISTS personajes;
DROP TABLE IF EXISTS juegos;

-- ============================================================================
-- 2. CREACIÓN DE TABLAS
-- ============================================================================

-- Catálogos (Tablas independientes)
CREATE TABLE juegos (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Nombre TEXT NOT NULL
);

CREATE TABLE personajes (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Nombre TEXT NOT NULL,
    PrecioCompra DECIMAL NOT NULL DEFAULT 500,
    PrecioRevivir DECIMAL NOT NULL DEFAULT 250
);

CREATE TABLE administradores (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Nombre TEXT NOT NULL,
    Contrasena TEXT NOT NULL
);

-- Cuentas de Usuario
CREATE TABLE usuarios (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Nombre TEXT NOT NULL,
    Contrasena TEXT NOT NULL
);

-- Inventario de Personajes (Ranuras de cada usuario)
CREATE TABLE personajes_guardados (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    UsuarioId INTEGER NOT NULL,
    PersonajeId INTEGER NOT NULL, -- ID del catálogo (Mago, Caballero, Picaro)
    Saldo DECIMAL NOT NULL,
    EstaVivo INTEGER NOT NULL DEFAULT 1,
    FOREIGN KEY (UsuarioId) REFERENCES usuarios(Id),
    FOREIGN KEY (PersonajeId) REFERENCES personajes(Id)
);

-- Historial de Juegos (Como lo tenías + PersonajeId + GananciaPerdida, sin fecha)
CREATE TABLE historial_juegos (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    UsuarioId INTEGER NOT NULL,
    JuegoId INTEGER NOT NULL,
    PersonajeId INTEGER NOT NULL, -- Hace referencia al personaje guardado que jugó
    SaldoInicial DECIMAL NOT NULL,
    NumReapuestas INTEGER NOT NULL,
    GananciaPerdida DECIMAL NOT NULL,
    FOREIGN KEY (UsuarioId) REFERENCES usuarios(Id),
    FOREIGN KEY (JuegoId) REFERENCES juegos(Id),
    FOREIGN KEY (PersonajeId) REFERENCES personajes_guardados(Id)
);

-- ============================================================================
-- 3. INSERCIÓN DE VALORES POR DEFECTO
-- ============================================================================

-- Llenar los 3 juegos
INSERT INTO juegos (Id, Nombre) VALUES 
(1, 'Ruleta'), 
(2, 'BlackJack'), 
(3, 'Carrera de Caballos');

-- Llenar los 3 personajes base
INSERT INTO personajes (Nombre, PrecioCompra, PrecioRevivir) VALUES 
('Bárbaro', 500, 250),
('Pícaro', 500, 250),
('Hechicero', 500, 250),
('Bardo', 500, 250),
('Hada', 500, 250),
('Sirena', 500, 250),
('Bruja', 500, 250),
('Cazador', 500, 250),
('Caballero', 500, 250);

-- Llenar 5 administradores
INSERT INTO administradores (Id, Nombre, Contrasena) VALUES 
(1, 'AdminPrincipal', 'admin123'),
(2, 'GerenteTurno', 'gerente123'),
(3, 'AuditorSistemas', 'auditor123'),
(4, 'JefeSeguridad', 'seguridad123'),
(5, 'SoporteTecnico', 'soporte123');

-- Llenar 5 usuarios normales
INSERT INTO usuarios (Id, Nombre, Contrasena) VALUES 
(1, 'JugadorUno', 'pass1'),
(2, 'JugadorDos', 'pass2'),
(3, 'JugadorTres', 'pass3'),
(4, 'JugadorCuatro', 'pass4'),
(5, 'JugadorCinco', 'pass5');

-- Asignar los 3 personajes a cada uno de los 5 usuarios (15 personajes en total)
-- Usuario 1
INSERT INTO personajes_guardados (Id, UsuarioId, PersonajeId, Saldo, EstaVivo) VALUES 
(1, 1, 1, 1000, 1), (2, 1, 2, 850, 1), (3, 1, 3, 0, 0);
-- Usuario 2
INSERT INTO personajes_guardados (Id, UsuarioId, PersonajeId, Saldo, EstaVivo) VALUES 
(4, 2, 1, 200, 1), (5, 2, 2, 1500, 1), (6, 2, 3, 300, 1);
-- Usuario 3
INSERT INTO personajes_guardados (Id, UsuarioId, PersonajeId, Saldo, EstaVivo) VALUES 
(7, 3, 1, 0, 0), (8, 3, 2, 0, 0), (9, 3, 3, 5000, 1);
-- Usuario 4
INSERT INTO personajes_guardados (Id, UsuarioId, PersonajeId, Saldo, EstaVivo) VALUES 
(10, 4, 1, 750, 1), (11, 4, 2, 120, 1), (12, 4, 3, 900, 1);
-- Usuario 5
INSERT INTO personajes_guardados (Id, UsuarioId, PersonajeId, Saldo, EstaVivo) VALUES 
(13, 5, 1, 2500, 1), (14, 5, 2, 0, 0), (15, 5, 3, 400, 1);

-- Generar el historial: Cada usuario juega con sus 3 personajes en los 3 juegos (45 partidas)
-- Formato: UsuarioId, JuegoId, PersonajeId(Ranura), SaldoInicial, NumReapuestas, GananciaPerdida

-- Historial Usuario 1 (Juega con sus ranuras 1, 2 y 3)
INSERT INTO historial_juegos (UsuarioId, JuegoId, PersonajeId, SaldoInicial, NumReapuestas, GananciaPerdida) VALUES 
(1, 1, 1, 1000, 2, 150), (1, 2, 1, 1150, 0, -50), (1, 3, 1, 1100, 1, -100),
(1, 1, 2, 800, 3, 50),   (1, 2, 2, 850, 1, 100),  (1, 3, 2, 950, 0, -100),
(1, 1, 3, 200, 0, -200), (1, 2, 3, 0, 0, 0),      (1, 3, 3, 0, 0, 0);

-- Historial Usuario 2 (Juega con sus ranuras 4, 5 y 6)
INSERT INTO historial_juegos (UsuarioId, JuegoId, PersonajeId, SaldoInicial, NumReapuestas, GananciaPerdida) VALUES 
(2, 1, 4, 300, 1, -100), (2, 2, 4, 200, 2, 200),  (2, 3, 4, 400, 0, -200),
(2, 1, 5, 1000, 0, 500), (2, 2, 5, 1500, 3, -100),(2, 3, 5, 1400, 1, 100),
(2, 1, 6, 300, 0, 150),  (2, 2, 6, 450, 1, -150), (2, 3, 6, 300, 2, 0);

-- Historial Usuario 3 (Juega con sus ranuras 7, 8 y 9)
INSERT INTO historial_juegos (UsuarioId, JuegoId, PersonajeId, SaldoInicial, NumReapuestas, GananciaPerdida) VALUES 
(3, 1, 7, 100, 0, -100), (3, 2, 7, 0, 0, 0),      (3, 3, 7, 0, 0, 0),
(3, 1, 8, 50, 1, -50),   (3, 2, 8, 0, 0, 0),      (3, 3, 8, 0, 0, 0),
(3, 1, 9, 4000, 4, 500), (3, 2, 9, 4500, 2, 300), (3, 3, 9, 4800, 5, 200);

-- Historial Usuario 4 (Juega con sus ranuras 10, 11 y 12)
INSERT INTO historial_juegos (UsuarioId, JuegoId, PersonajeId, SaldoInicial, NumReapuestas, GananciaPerdida) VALUES 
(4, 1, 10, 500, 1, 250), (4, 2, 10, 750, 0, -100),(4, 3, 10, 650, 2, 100),
(4, 1, 11, 200, 3, -80), (4, 2, 11, 120, 1, 50),  (4, 3, 11, 170, 0, -50),
(4, 1, 12, 1000, 0, -100),(4, 2, 12, 900, 1, 200), (4, 3, 12, 1100, 2, -200);

-- Historial Usuario 5 (Juega con sus ranuras 13, 14 y 15)
INSERT INTO historial_juegos (UsuarioId, JuegoId, PersonajeId, SaldoInicial, NumReapuestas, GananciaPerdida) VALUES 
(5, 1, 13, 2000, 0, 300), (5, 2, 13, 2300, 4, 100), (5, 3, 13, 2400, 1, 100),
(5, 1, 14, 50, 2, -50),   (5, 2, 14, 0, 0, 0),      (5, 3, 14, 0, 0, 0),
(5, 1, 15, 300, 1, 150),  (5, 2, 15, 450, 0, -50),  (5, 3, 15, 400, 3, 0);

-- ========================================================
-- =                 QUERIES USUARIOS                     =
-- ========================================================

--Validar usuario
SELECT Id
FROM usuarios
WHERE Nombre = @nombre AND Contrasena = @contrasena;

--Guardar registro de partida
INSERT INTO historial_juegos (UsuarioId, JuegoId, SaldoInicial, NumReapuestas, Ganancia) 
VALUES (@usuarioId, @juegoid, @saldoInicial, @numReapuestas, @ganancia);

--Añadir usuario
INSERT INTO usuarios (Nombre, Contrasena, Saldo, PersonajeId) VALUES
(@nombre, @contrasena, 1000, @personajeid);

--Borrar usuario
DELETE FROM historial_juegos WHERE UsuarioId = @id;
DELETE FROM usuarios WHERE Id = @id;

-- ========================================================
-- =                 QUERIES REPORTES                     =
-- ========================================================

--Obtener todos los personajes
SELECT Id, Nombre 
FROM personajes 
ORDER BY Id ASC;

--Obtener todos los juegos
SELECT Id, Nombre 
FROM juegos 
ORDER BY Id ASC;

--USUARIOS POR PERSONAJE
--  dado el nombre
SELECT 
    u.Id AS UsuarioId, 
    u.Nombre AS Jugador, 
    u.Saldo, 
    p.Nombre AS PersonajeElegido
FROM usuarios u
INNER JOIN personajes p ON u.PersonajeId = p.Id
WHERE p.Nombre = @nombrePersonaje; --> nombre solicitado

--  dado el id
SELECT Id, Nombre, Saldo 
FROM usuarios 
WHERE PersonajeId = @idPersonaje;

--USUARIOS POR JUEGO
--  dado el nombre
SELECT DISTINCT 
    u.Id AS UsuarioId, 
    u.Nombre AS Jugador, 
    u.Saldo
FROM usuarios u
INNER JOIN historial_juegos h ON u.Id = h.UsuarioId
INNER JOIN juegos j ON h.JuegoId = j.Id
WHERE j.Nombre = @nombreJuego; --> nombre solicitado

--  dado el id
SELECT DISTINCT u.Id, u.Nombre, u.Saldo 
FROM usuarios u
INNER JOIN historial_juegos h ON u.Id = h.UsuarioId
WHERE h.JuegoId = @idJuego;