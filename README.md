# Geolocator
> Program ini adalah program pencarian rute menggunakan algoritma A* untuk memenuhi spesifikasi Tugas Kecil IF2211 Strategi Algoritma 2021.

## Table of contents
* [General info](#general-info)
* [Screenshots](#screenshots)
* [Technologies](#technologies)
* [Setup](#setup)
* [Features](#features)
* [Status](#status)
* [Inspiration](#inspiration)
* [Contact](#contact)

## General info
Algoritma A* (atau A star) dapat digunakan untuk menentukan lintasan terpendek dari suatu titik ke titik lain. Pada tugas kecil 3 ini, anda diminta menentukan lintasan terpendek berdasarakan peta Google Map jalan-jalan di kota Bandung. Dari ruas-ruas jalan di peta dibentuk graf. Simpul menyatakan persilangan jalan atau ujung jalan. Asumsikan jalan dapat dilalui dari dua arah. Bobot graf menyatakan jarak (m atau km) antar simpul. Jarak antar dua simpul dapat dihitung dari koordinat kedua simpul menggunakan rumus jarak Euclidean (berdasarkan koordinat) atau dapat menggunakan ruler di Google Map, atau cara lainnya yang disediakan oleh Google Map.

## Screenshots
![Load File](./img/img1.png)

![Create Graph](./img/img2.png)

## Technologies
* GMap.NET.Core  - version 2.0.2.0
* System.Data.SQLite - version 1.0.113.0

## Setup
1. Install program menggunakan Geolocator.msi atau setup.exe pada folder bin
2. Jalankan program Geolocator.exe dengan membukanya dari shortcut yang dibuat di desktop atau dari ProgramFiles/Geolocator/

## Usage
### Load Files
1. Pilih file yang ingin diload menggunakan tombol browse
2. Pilih 2 lokasi yang ingin dicari jalur terpendeknya menggunakan combobox
3. Klik "Get Route" untuk menampilkan rute pada peta
4. (Opsional) Klik tombol "Check matrix" untuk melihat adjacency matrix dari graph

### Creating New Graph
1. Navigasi aplikasi ke tab "Manual Point"
2. Tentukan koordinat yang ingin dibuat graphnya (initial location) dengan mengisi koordinat latitude dan longitude
3. (Opsional) Klik tombol "Default location" untuk langsung navigasi ke ITB
4. Klik 2x pada peta untuk menjatuhkan pin (pin bisa digerakkan dengan mengklik 2x pada peta)
5. Masukkan nama lokasi yang sudah ditandai pada textbox "Point Name" dan klik tombol "Add Point"
6. Ulangi langkah 4-5 jika membutuhkan node lebih
7. Pilih nama node yang telah dibuat pada combobox Node 1 dan Node 2 dan klik "Add Sisi" untuk menambahkan sisi graph
8. Ulangi langkah 7 jika membutuhkan sisi lebih (bisa kembali ke langkah 4 jika dibutuhkan)
9. (opsional) Klik tombol "Check Matrix" untuk melihat adjacency matrix dari graph
10. Jika graph sudah selesai dibuat, klik tombol "Export to txt" untuk mengexport file ke txt yang bisa digunakan pada tab Load Files

## Features
List of features ready
* Load file txt dan menampilkannya pada peta
* Mencari rute terpendek menggunakan Haversine dan Algoritma A*
* Membuat map sendiri menggunakan GUI pada aplikasi
* Melihat adjacency matrix pada graph yang sedang dibuat
* Melihat path jalur terpendek pada map

## Status
Project is: _finished_

## Inspiration
[Referensi Pembuatan Algoritma](http://informatika.stei.itb.ac.id/~rinaldi.munir/Stmik/2020-2021/Route-Planning-Bagian2-2021.pdf)
[Referensi Implementasi API](http://www.independent-software.com/category/gmap.html)
[Spesifikasi Tugas Kecil](http://informatika.stei.itb.ac.id/~rinaldi.munir/Stmik/2020-2021/Tugas-Kecil-3-(2021).pdf)

## Contact
Created By:

Alvin Wilta [@alvinwilta](https://github.com/alvinwilta) - 13519163

Leonard Matheus [@leomatt547](https://github.com/leomatt547) - 13519215
