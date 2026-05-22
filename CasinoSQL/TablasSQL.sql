DROP TABLE IF EXISTS [usuarios];

CREATE TABLE usuarios (
    Nombre TEXT NOT NULL,
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Contrasena TEXT NOT NULL,
    Saldo DECIMAL NOT NULL
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