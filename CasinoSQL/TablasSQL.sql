-- Primero borramos el historial (el hijo) que depende de los usuarios
DROP TABLE IF EXISTS [historial_juegos];
-- Ahora sí, como ya no hay nadie que dependa de ella, borramos la de usuarios
DROP TABLE IF EXISTS [usuarios];

CREATE TABLE usuarios(
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Nombre TEXT NOT NULL,
    Contrasena TEXT NOT NULL,
    Saldo DECIMAL NOT NULL,
    Personaje TEXT NOT NULL
);

CREATE TABLE historial_juegos(
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    UsuarioId INTEGER NOT NULL,
    Juego TEXT NOT NULL,
    Ganancia DECIMAL NOT NULL,
    FOREIGN KEY (UsuarioId) REFERENCES Usuarios(Id)
);

INSERT INTO usuarios (Nombre, Contrasena, Saldo, Personaje) VALUES 
('Juan Perez', 'clave123', 1500.50, 'Personaje 1'),
('Maria Garcia', 'maria_pass', 500.00, 'Personaje 2'),
('Luis Fernandez', 'luis2026', 0.00, 'Personaje 3'),
('Carmen Salinas', 'carmen1', 3200.75, 'Personaje 1'),
('Jorge Nitales', 'jorgepwd', 150.20, 'Personaje 2'),
('Andrea Lopez', 'andy_l', 850.00, 'Personaje 3'),
('Roberto Gomez', 'rob1234', 12000.00, 'Personaje 1'),
('Sofia Torres', 'sofi_t', 45.50, 'Personaje 2'),
('Miguel Diaz', 'mikediaz', 600.00, 'Personaje 3'),
('Elena Navarro', 'elena99', 1000.00, 'Personaje 1');

INSERT INTO historial_juegos(UsuarioId, Juego, Ganancia) VALUES
(1, 'Ruleta', 150.00),             
(1, 'BlackJack', -50.00),          
(2, 'Carrera de caballos', 200.00),
(3, 'Ruleta', -100.00),            
(4, 'BlackJack', 300.00),          
(4, 'Carrera de caballos', -20.50),
(5, 'Ruleta', 10.00),              
(6, 'BlackJack', -80.00),          
(7, 'Carrera de caballos', 500.00),
(8, 'Ruleta', -45.50),             
(9, 'BlackJack', 120.00),          
(10, 'Carrera de caballos', -30.00);

-- QUERIES

--Validar usuario
SELECT Id
FROM usuarios
WHERE Nombre = @nombre AND Contrasena = @contrasena;

--Guardar registro de partida
INSERT INTO Historial (NombreJuego, Ganancia) VALUES
(@juego, @ganancia);

--Añadir usuario
INSERT INTO Usuarios (Nombre, Contrasena, Saldo, Personaje) VALUES
(@nombre, @contrasena, 1000, @personaje);

--Borrar usuario
DELETE FROM historial_juegos WHERE UsuarioId = @id;
DELETE FROM usuarios WHERE Id = @id;

--Filtro usuarios por personaje
SELECT Id, Nombre, Saldo, Personaje
FROM usuarios
WHERE Personaje = @personaje;