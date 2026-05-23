-- ========================================================
-- 1. BORRADO DE TABLAS (En orden inverso de dependencia)
-- ========================================================
DROP TABLE IF EXISTS historial_juegos;
DROP TABLE IF EXISTS usuarios;
DROP TABLE IF EXISTS personajes;
DROP TABLE IF EXISTS juegos;

-- ========================================================
-- 2. CREACIÓN DE TABLAS INDEPENDIENTES (Catálogos)
-- ========================================================
CREATE TABLE juegos (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Nombre TEXT NOT NULL
);

CREATE TABLE personajes (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Nombre TEXT NOT NULL
);

-- ========================================================
-- 3. CREACIÓN DE TABLAS DEPENDIENTES
-- ========================================================
-- La tabla usuarios ahora depende de la tabla personajes
CREATE TABLE usuarios (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Nombre TEXT NOT NULL,
    Contrasena TEXT NOT NULL,
    Saldo DECIMAL NOT NULL,
    PersonajeId INTEGER NOT NULL,
    FOREIGN KEY (PersonajeId) REFERENCES personajes(Id)
);

-- El historial ahora depende tanto de usuarios como de juegos
CREATE TABLE historial_juegos (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    UsuarioId INTEGER NOT NULL,
    JuegoId INTEGER NOT NULL,
    SaldoInicial DECIMAL NOT NULL,
    NumReapuestas INTEGER NOT NULL,
    Ganancia DECIMAL NOT NULL,
    FOREIGN KEY (UsuarioId) REFERENCES usuarios(Id),
    FOREIGN KEY (JuegoId) REFERENCES juegos(Id)
);

-- ========================================================
-- 4. INSERCIÓN DE DATOS INICIALES (Catálogos)
-- ========================================================
-- Juegos (Id 1: Ruleta, Id 2: BlackJack, Id 3: Caballos)
INSERT INTO juegos (Nombre) VALUES 
('Ruleta'), 
('BlackJack'), 
('Carrera de caballos');

-- Personajes (Id 1: Personaje 1, Id 2: Personaje 2, Id 3: Personaje 3)
INSERT INTO personajes (Nombre) VALUES 
('Personaje 1'), 
('Personaje 2'), 
('Personaje 3');

-- ========================================================
-- 5. INSERCIÓN DE LOS 10 USUARIOS (Usando PersonajeId)
-- ========================================================
INSERT INTO usuarios (Nombre, Contrasena, Saldo, PersonajeId) VALUES 
('Juan Perez', 'clave123', 1500.50, 1),
('Maria Garcia', 'maria_pass', 500.00, 2),
('Luis Fernandez', 'luis2026', 0.00, 3),
('Carmen Salinas', 'carmen1', 3200.75, 1),
('Jorge Nitales', 'jorgepwd', 150.20, 2),
('Andrea Lopez', 'andy_l', 850.00, 3),
('Roberto Gomez', 'rob1234', 12000.00, 1),
('Sofia Torres', 'sofi_t', 45.50, 2),
('Miguel Diaz', 'mikediaz', 600.00, 3),
('Elena Navarro', 'elena99', 1000.00, 1);

-- ========================================================
-- 6. INSERCIÓN DEL HISTORIAL (Usando UsuarioId y JuegoId)
-- ========================================================
INSERT INTO historial_juegos (UsuarioId, JuegoId, SaldoInicial, NumReapuestas, Ganancia) VALUES 
-- Usuario 1 (Juan Perez)
(1, 1, 1000.00, 2, 150.00),   -- 1 = Ruleta
(1, 2, 1150.00, 0, -50.00),  -- 2 = BlackJack
(1, 3, 1100.00, 1, 400.50),  -- 3 = Carrera de caballos

-- Usuario 2 (Maria Garcia)
(2, 2, 1000.00, 3, 200.00),
(2, 1, 1200.00, 1, -100.00),
(2, 3, 1100.00, 0, -50.00),

-- Usuario 3 (Luis Fernandez)
(3, 3, 1000.00, 0, -200.00),
(3, 1, 800.00, 4, 300.00),
(3, 2, 1100.00, 1, -150.00),

-- Usuario 4 (Carmen Salinas)
(4, 1, 1000.00, 2, 50.00),
(4, 2, 1050.00, 1, 150.75),
(4, 3, 1200.75, 5, 2000.00),

-- Usuario 5 (Jorge Nitales)
(5, 2, 1000.00, 0, -500.00),
(5, 3, 500.00, 1, -200.00),
(5, 1, 300.00, 2, -149.80),

-- Usuario 6 (Andrea Lopez)
(6, 1, 1000.00, 1, -100.00),
(6, 3, 900.00, 0, 50.00),
(6, 2, 950.00, 2, -100.00),

-- Usuario 7 (Roberto Gomez)
(7, 3, 1000.00, 0, 5000.00),
(7, 2, 6000.00, 4, 4000.00),
(7, 1, 10000.00, 3, 2000.00),

-- Usuario 8 (Sofia Torres)
(8, 1, 1000.00, 5, -500.00),
(8, 2, 500.00, 2, -400.00),
(8, 3, 100.00, 1, -54.50),

-- Usuario 9 (Miguel Diaz)
(9, 2, 1000.00, 0, 100.00),
(9, 1, 1100.00, 1, -200.00),
(9, 3, 900.00, 2, -300.00),

-- Usuario 10 (Elena Navarro)
(10, 3, 1000.00, 1, 200.00),
(10, 1, 1200.00, 0, -100.00),
(10, 2, 1100.00, 1, -100.00);

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

--Filtro usuarios por personaje
SELECT 
    u.Id AS UsuarioId, 
    u.Nombre AS Jugador, 
    u.Saldo, 
    p.Nombre AS PersonajeElegido
FROM usuarios u
INNER JOIN personajes p ON u.PersonajeId = p.Id
WHERE p.Nombre = @nombrePersonaje;