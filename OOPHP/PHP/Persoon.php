<?php

class Person {
    public $naam;
    private $leeftijd;
    private $geslacht;
    public $isStudent;
    public $gemiddeldCijfer;

    public function __construct($naam, $leeftijd, $geslacht, $isStudent, $gemiddeldCijfer) {
        $this->naam = $naam;
        $this->leeftijd = $leeftijd;
        $this->geslacht = $geslacht;
        $this->isStudent = $isStudent;
        $this->gemiddeldCijfer = $gemiddeldCijfer;
    }
}

?>