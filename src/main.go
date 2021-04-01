package main

import (
	"bufio"
	"fmt"
	//"io/ioutil"
	"log"
	"os"
	"strings"
)

type Simpul struct {
	Lat, Long float64
}

//var Kamus map[Simpul]int
var Node int
var DataNode [][]string
var Kamus map[int]string

func input(filename string) {
	file, err := os.Open(filename)
    if err != nil {
        log.Fatal(err)
    }
    defer file.Close()

    scanner := bufio.NewScanner(file)
	var Temp []string;
    for scanner.Scan() {
		s := strings.Split(scanner.Text(), " ")
		for i := 0; i < len(s); i++{
			Temp = append(Temp, s[i])
		}
		DataNode = append(DataNode, Temp)
    }

    if err := scanner.Err(); err != nil {
        log.Fatal(err)
    }
	
}

//contains(array of string, elemen)
func contains(s []string, e string) bool {
    for _, a := range s {
        if a == e {
            return true
        }
    }
    return false
}

func printSliceString(s []string) {
	for _, value:= range s {
	  fmt.Printf("%v ", value)
	}
	fmt.Printf("\n")
}

func main(){
	var filename string = "test/graph.txt"
	input(filename)
	//Buat Set dulu
	Kamus = make(map[int]string)
	var Set []string;
	for i:=0; i<len(DataNode); i++{
		fmt.Printf("panjang Set = %d\n", len(Set))
		if !contains(Set, DataNode[i][0]){
			Set = append(Set, DataNode[i][0])
		}
		if !contains(Set, DataNode[i][1]){
			Set = append(Set, DataNode[i][1])
		}
	}

	//Masukkan ke dictionary Kamus
	for i, elemen:= range Set {
		Kamus[i] = elemen
		fmt.Printf("%s",elemen)
	}
	for i, elemen:= range Set {
		Kamus[i] = elemen
	}
	for key, _ := range Kamus {
        if _, ok:= Kamus[key]; ok {         
            fmt.Printf("%d\n", key)
        }
    }   

	fmt.Printf("panjang DataNode = %d\n", len(DataNode))
	fmt.Printf("panjang Set = %d\n", len(Set))
	
}
