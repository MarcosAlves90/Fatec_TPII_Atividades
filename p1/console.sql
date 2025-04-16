-- Allocators table
CREATE TABLE allocators
(
    cpf             CHAR(11) PRIMARY KEY,
    name            VARCHAR(255) NOT NULL,
    phone           VARCHAR(15)
);

-- Genres table
CREATE TABLE genres
(
    id          SERIAL PRIMARY KEY,
    description VARCHAR(100) NOT NULL UNIQUE
);

-- Authors table
CREATE TABLE authors
(
    id          SERIAL PRIMARY KEY,
    name        VARCHAR(255) NOT NULL UNIQUE
);

-- Books table
CREATE TABLE books
(
    id              SERIAL PRIMARY KEY,
    title           VARCHAR(255) NOT NULL,
    author_id       INTEGER NOT NULL,
    genre_id        INTEGER,
    release_year    INTEGER CHECK (release_year BETWEEN -2000 AND EXTRACT(YEAR FROM CURRENT_DATE)),
    cover_image     BYTEA,
    CONSTRAINT fk_author FOREIGN KEY (author_id) REFERENCES authors(id),
    CONSTRAINT fk_genre FOREIGN KEY (genre_id) REFERENCES genres(id)
);

-- Allocation status table
CREATE TABLE allocation_status
(
    id              SERIAL PRIMARY KEY,
    book_id         INTEGER NOT NULL,
    allocator_id    CHAR(11) NOT NULL,
    allocation_date DATE NOT NULL,
    return_date     DATE NOT NULL,
    CONSTRAINT fk_book FOREIGN KEY (book_id) REFERENCES books(id),
    CONSTRAINT fk_allocator FOREIGN KEY (allocator_id) REFERENCES allocators(cpf),
    CHECK (return_date IS NULL OR return_date >= allocation_date)
);