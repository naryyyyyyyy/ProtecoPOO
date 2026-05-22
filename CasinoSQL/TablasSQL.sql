DROP TABLE IF EXISTS [usuarios];
DROP TABLE IF EXISTS [historial_juegos];

CREATE TABLE usuarios(
    Nombre TEXT NOT NULL,
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Contrasena TEXT NOT NULL,
    Saldo DECIMAL NOT NULL
);

CREATE TABLE historial_juegos(
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    UsuarioId INTEGER NOT NULL,
    Juego TEXT NOT NULL,
    Ganancia DECIMAL NOT NULL,
    FOREIGN KEY (UsuarioId) REFERENCES Usuarios(Id)
);

INSERT INTO usuarios (Nombre, Contrasena, Saldo) VALUES 
('Juan Perez', 'clave123', 1500.50),
('Maria Garcia', 'maria_pass', 500.00),
('Luis Fernandez', 'luis2026', 0.00),
('Carmen Salinas', 'carmen1', 3200.75),
('Jorge Nitales', 'jorgepwd', 150.20),
('Andrea Lopez', 'andy_l', 850.00),
('Roberto Gomez', 'rob1234', 12000.00),
('Sofia Torres', 'sofi_t', 45.50),
('Miguel Diaz', 'mikediaz', 600.00),
('Elena Navarro', 'elena99', 1000.00);

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

SELECT Id
FROM usuarios u 
WHERE nombre = u.Nombre AND contrasena = u.Contrasena;