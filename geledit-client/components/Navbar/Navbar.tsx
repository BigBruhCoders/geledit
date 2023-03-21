import {NavBarBox, NavBarSpace, NavBarNameLink, NavBarLoginBox} from "styles/Navbar/navbar";
import {Button, FormControl, InputLabel, MenuItem, Select, SelectChangeEvent} from "@mui/material";
import {getCookie} from "cookies-next";
import {useEffect, useState} from "react";
import type {ChangeTheme} from "types/navbar";

const Navbar = ({changeTheme}: { changeTheme: ChangeTheme }) => {
    const [currTheme, setTheme] = useState("light");

    const handleChangeTheme = (event: SelectChangeEvent) => {
        changeTheme(event.target.value as string);
        setTheme(event.target.value as string);
    };

    useEffect(() => {
        setTheme(getCookie("NEXT_THEME") as string || "light")
    }, []);

    return <>
        <NavBarBox>
            <NavBarNameLink href="/">
                <p>GELEDIT</p>
            </NavBarNameLink>
            <NavBarSpace/>
            <FormControl>
                <InputLabel id="theme-label">Theme</InputLabel>
                <Select
                    labelId="theme-label"
                    value={currTheme}
                    label="Theme"
                    onChange={handleChangeTheme}
                    variant="standard"
                    sx={{m: 2, minWidth: 120}}
                >
                    <MenuItem value={"light"}>Light</MenuItem>
                    <MenuItem value={"dark"}>Dark</MenuItem>
                    <MenuItem value={"green"}>Green</MenuItem>
                </Select>
            </FormControl>
            <NavBarLoginBox>
                <Button variant="outlined">Zaloguj się</Button>
            </NavBarLoginBox>
        </NavBarBox>
    </>
}

export default Navbar;